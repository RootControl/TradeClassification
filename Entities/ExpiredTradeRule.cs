using TradeClassification.Interfaces;

namespace TradeClassification.Entities;

public class ExpiredTradeRule : ITradeRule
{
    public string GetCategory(ITrade trade, DateTime referenceDate)
    {
        return (referenceDate > trade.NextPaymentDate.AddDays(30)) ? "EXPIRED" : string.Empty;
    }
}