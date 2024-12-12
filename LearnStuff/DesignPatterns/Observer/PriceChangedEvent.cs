namespace LearnStuff.DesignPatterns.Observer;

public class PriceChangedEvent : EventArgs
{
    public string Symbol { get; set; } = "";
    public double Price { get; set; }
}