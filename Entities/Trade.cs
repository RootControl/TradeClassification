using TradeClassification.Interfaces;

namespace TradeClassification.Entities;

public class Trade : ITrade
{
    public double Value { get; }
    public string ClientSector { get; }
    public DateTime NextPaymentDate { get; }

    public Trade(double value, string clientSector, DateTime nextPamentDate)
    {
        Value = value;
        ClientSector = clientSector;
        NextPaymentDate = nextPamentDate;
    }
}