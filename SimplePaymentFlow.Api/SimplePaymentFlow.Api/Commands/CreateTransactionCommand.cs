namespace SimplePaymentFlow.Api.Commands;

public class CreateTransactionCommand
{
    public decimal TransactionValue { get; set; }
    public Guid PumpId { get; set; }
}