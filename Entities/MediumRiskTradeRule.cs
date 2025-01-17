using TradeClassification.Interfaces;

namespace TradeClassification.Entities;

public class MediumRiskTradeRule : ITradeRule
{
    public string GetCategory(ITrade trade, DateTime referenceDate)
    {
        return trade is { Value: > 1_000_000, ClientSector: "Public" } ? "MEDIUMRISK" : string.Empty;
    }
}