namespace LearnStuff.DataStructuresAndAlgorithms.HashTables;

public class Hash
{
    private readonly int _bucket;
    private readonly List<int>[] _table;

    public Hash(int value)
    {
        _bucket = value;
        _table = new List<int>[_bucket];

        for (var i = 0; i < _bucket; i++)
        {
            _table[i] = [];
        }
    }

    private int HashFunction(int key)
    {
        return (key % _bucket);
    }

    public void InsertItem(int key)
    {
        var index = HashFunction(key);
        _table[index].Add(key);
    }

    public void DisplayHash()
    {
        for (var i = 0; i < _bucket; i++)
        {
            Console.Write(i + " --> ");
            foreach (var x in _table[i])
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}