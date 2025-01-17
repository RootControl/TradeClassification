namespace TradeClassification.Interfaces;

public interface ITradeClassifier
{
    public IEnumerable<string> ClassifyTrades(IEnumerable<ITrade> trades, DateTime referenceDate);
}