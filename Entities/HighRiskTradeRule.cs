using TradeClassification.Interfaces;

namespace TradeClassification.Entities;

public class HighRiskTradeRule : ITradeRule
{
    public string GetCategory(ITrade trade, DateTime referenceDate)
    {
        return trade is { Value: > 1_000_000, ClientSector: "Private" } ? "HIGHRISK" : string.Empty;
    }
}