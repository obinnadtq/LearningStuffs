namespace LearnStuff.DesignPatterns.Strategy;

public class ShellSort : ISortStrategy
{
    public void Sort(List<Student> students)
    {
        Console.WriteLine("Shell Sort");
    }
}