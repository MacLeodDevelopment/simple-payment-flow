using SimplePaymentFlow.Api.Commands;
using SimplePaymentFlow.Api.Infrastructure;
using SimplePaymentFlow.Api.Models;

namespace SimplePaymentFlow.Api.Handlers;

internal class TransactionCommandHandler
{
    public Task<Transaction> Handle(CreateTransactionCommand createTransactionCommand)
    {
        var pump = StaticPumpStore.Pumps.Single(p => p.Id == createTransactionCommand.PumpId);

        var transaction = new Transaction(createTransactionCommand.TransactionValue)
        {
            Status = "Success",
            TimeStamp = DateTimeOffset.Now,
            PumpName = pump.Name
        };
        
        StaticTransactionStore.Create(transaction);

        return Task.FromResult(transaction);
    }
}