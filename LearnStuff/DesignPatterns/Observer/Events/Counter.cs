namespace LearnStuff.DesignPatterns.Observer.Events;

public class Counter
{
    // declaring event ThresholdReached;
    public event EventHandler ThresholdReached;

    protected virtual void OnThresholdReached(EventArgs e)
    {
        ThresholdReached?.Invoke(this, e);
    }
}