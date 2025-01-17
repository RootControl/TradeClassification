namespace TradeClassification.Interfaces;

public interface ITrade
{
    public double Value { get; }
    public string ClientSector { get; }
    public DateTime NextPaymentDate { get; }
}