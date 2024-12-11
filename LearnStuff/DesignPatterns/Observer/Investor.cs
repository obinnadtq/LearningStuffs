namespace LearnStuff.DesignPatterns.Observer;

public class Investor : IInvestor
{
    public string Name { get; set; } = "";
    public Stock Stock { get; set; } = default!;
    public void Update(Stock stock)
    {
        throw new NotImplementedException();
    }
}