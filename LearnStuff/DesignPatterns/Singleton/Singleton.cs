namespace LearnStuff.DesignPatterns.Singleton;

/// <summary>
/// Singleton Design Pattern
/// </summary>
public sealed class Singleton
{
    private static readonly Singleton Instance = new();
    private readonly List<Server> _servers;
    private readonly Random _random = new();

    private Singleton()
    {
        _servers =
        [
            new Server("Server1", "1.1.1"),
            new Server("Server2", "2.2.2")
        ];
    }

    public static Singleton GetInstance() => Instance;

    public Server NextServer => _servers[_random.Next(_servers.Count)];
}

public record Server(string Name, string Ip);