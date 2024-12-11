namespace LearnStuff.DesignPatterns.Observer;

public abstract class Stock(string symbol, double price)
{
    private List<IInvestor> investors = [];

    public double Price
    {
        
        get => price;
        set
        {
            if (price != value)
            {
                price = value;
                Notify();
            }
        }
    }

    public string Symbol { get; } = symbol;

    public void Attach(IInvestor investor)
    {
        investors.Add(investor);
    }
    
    public void Detach(IInvestor investor)
    {
        investors.Remove(investor);
    }

    public void Notify()
    {
        foreach (var investor in investors)
        {
            investor.Update(this);
        }
    }
}