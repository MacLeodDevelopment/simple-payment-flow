using SimplePaymentFlow.Api.Commands;
using SimplePaymentFlow.Api.Handlers;
using SimplePaymentFlow.Api.Infrastructure;

namespace SimplePaymentFlow.Api
{
    public class Program
    {
        /*
         * Poor person's DI. 
         */
        private static readonly PumpCommandHandler PumpCommandHandler = new();
        private static readonly TransactionCommandHandler TransactionCommandHandler = new();

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Allow any origin for expediency. Obviously we wouldn't allow this in a production system. 
            builder.Services.AddCors(c => c.AddPolicy("PaymentFlowCorsPolicy", options =>
            {
                options.AllowAnyHeader();
                options.AllowAnyMethod();
                options.AllowAnyOrigin();
            }));


            var app = builder.Build();
            app.UseCors("PaymentFlowCorsPolicy");

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
           
            app.MapGet("/sites", (HttpContext _) =>
                {
                    var sites = StaticSiteStore.Sites.ToArray();
                    return sites;
                })
                .WithName("GetSites");

            // An HTTP PUT is deemed acceptable here for expediency. In a real-world scenario
            // this would be an HTTP PATCH, but it is not supported by minimal APIs.
            app.MapPut("/pump/{id}", async (Guid id, bool unlocked) =>
            {
                await PumpCommandHandler.Handle(new TogglePumpLockCommand(id, unlocked));
                return Results.NoContent();
            });

            app.MapPost("/transactions", async (CreateTransactionCommand createTransactionCommand) =>
            {
                var transaction = await TransactionCommandHandler.Handle(createTransactionCommand);

                return Results.Created($"/transactions/{transaction.Id}", transaction);
            });

            app.MapGet("/transactions/{id}", async (Guid id) =>
                await StaticTransactionStore.GetTransaction(id)
                    is { } transaction
                    ? Results.Ok(transaction)
                    : Results.NotFound());

            app.Run();
        }
    }
}