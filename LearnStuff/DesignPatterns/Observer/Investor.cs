namespace LearnStuff.DesignPatterns.Observer;

public class Investor : IInvestor
{
    public string Name { get; set; } = "";
    public Stock Stock { get; set; } = default!;
    public void Update(object? sender, PriceChangedEvent @event)
    {
        Console.WriteLine("Notified {0} of {1}'s " +
                          "change to {2:C}", Name, @event.Symbol, @event.Price);
    }
}