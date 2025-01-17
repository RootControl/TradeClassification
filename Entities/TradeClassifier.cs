using TradeClassification.Interfaces;

namespace TradeClassification.Entities;

public class TradeClassifier : ITradeClassifier
{
    private readonly IEnumerable<ITradeRule> _rules;

    public TradeClassifier()
    {
        _rules =
        [
            new ExpiredTradeRule(),
            new HighRiskTradeRule(),
            new MediumRiskTradeRule()
        ];
    }
    
    public IEnumerable<string> ClassifyTrades(IEnumerable<ITrade> trades, DateTime referenceDate)
    {
        return trades.Select(trade => ClassifyTrade(trade, referenceDate));
    }

    private string ClassifyTrade(ITrade trade, DateTime referenceDate)
    {
        foreach (var rule in _rules)
        {
            var category = rule.GetCategory(trade, referenceDate);
            
            if (!string.IsNullOrEmpty(category))
                return category;
        }

        return string.Empty;
    }
}