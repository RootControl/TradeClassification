using TradeClassification.Entities;
using TradeClassification.Interfaces;

var referenceDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);
var n = int.Parse(Console.ReadLine());

var trades = new List<ITrade>();
for (var i = 0; i < n; i++)
{
    var inputs = Console.ReadLine().Split(' ');
    trades.Add(new Trade(
        double.Parse(inputs[0]),
        inputs[1],
        DateTime.ParseExact(inputs[2], "MM/dd/yyyy", null)
    ));
}

var classifier = new TradeClassifier();
var categories = classifier.ClassifyTrades(trades, referenceDate);

foreach (var category in categories)
{
    Console.WriteLine(category);
}