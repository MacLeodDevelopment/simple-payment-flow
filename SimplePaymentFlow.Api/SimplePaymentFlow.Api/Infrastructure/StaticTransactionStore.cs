using SimplePaymentFlow.Api.Models;

namespace SimplePaymentFlow.Api.Infrastructure;

public class StaticTransactionStore
{
    private static readonly List<Transaction> Transactions;

    static StaticTransactionStore()
    {
        Transactions = new List<Transaction>();
    }

    public static void Create(Transaction transaction)
    {
        Transactions.Add(transaction);
    }

    public static Task<Transaction> GetTransaction(Guid id)
    {
        var transaction = Transactions.Single(t => t.Id == id);
        return Task.FromResult(transaction);
    }
}