namespace LearnStuff.DesignPatterns.Observer;

public abstract class Stock(string symbol, double price)
{
    public event EventHandler<PriceChangedEvent> PriceChanged = null!;
    protected virtual void OnPriceChanged(PriceChangedEvent @event)
    {
        PriceChanged?.Invoke(this, @event);
    }
    
    public void Attach(IInvestor investor)
    {
        PriceChanged += investor.Update;
    }
    
    public void Detach(IInvestor investor)
    {
        PriceChanged -= investor.Update;
    }

    public double Price
    {
        
        get => price;
        set
        {
            if (price != value)
            {
                price = value;
                OnPriceChanged(new PriceChangedEvent { Symbol = symbol, Price = price});
            }
        }
    }
}