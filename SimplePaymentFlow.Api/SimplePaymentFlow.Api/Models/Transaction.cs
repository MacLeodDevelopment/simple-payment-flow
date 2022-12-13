using System.Globalization;

namespace SimplePaymentFlow.Api.Models;

public class Transaction
{
    private readonly decimal _transactionValue;
    private readonly NumberFormatInfo _numberFormat;

    public Transaction(decimal transactionValue)
    {
        _transactionValue = transactionValue;
        PumpName = string.Empty;
        _numberFormat = new CultureInfo("en-GB", false).NumberFormat;

        Id = Guid.NewGuid();
        Status = "Not Set";
    }

    public Guid Id { get; }
    public string Status { get; set; }
    public DateTimeOffset TimeStamp { get; set; }
    public string PumpName { get; set; }
    // ReSharper disable once UnusedMember.Global
    public string TransactionValue => _transactionValue.ToString("C", _numberFormat);
}