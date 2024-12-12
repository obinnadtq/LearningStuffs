namespace LearnStuff.DesignPatterns.Strategy;

public class MergeSort : ISortStrategy
{
    public void Sort(List<Student> students)
    {
        Console.WriteLine("Merge Sort");
    }
}