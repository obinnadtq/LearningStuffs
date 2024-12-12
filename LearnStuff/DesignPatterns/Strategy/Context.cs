namespace LearnStuff.DesignPatterns.Strategy;

public class Context : List<Student>
{
    public ISortStrategy SortStrategy { get; set; } = null!;
    public void SortStudents()
    {
        SortStrategy.Sort(this);

        foreach (var student in this)
        {
            Console.WriteLine(student);
        }
    }
}