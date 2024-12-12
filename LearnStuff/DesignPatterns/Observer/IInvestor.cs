namespace LearnStuff.DesignPatterns.Observer;

public interface IInvestor
{
    void Update(object? sender, PriceChangedEvent @event);
}