namespace TradeClassification.Interfaces;

public interface ITradeRule
{
    public string GetCategory(ITrade trade, DateTime referenceDate);
}