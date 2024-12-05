// See https://aka.ms/new-console-template for more information

using LearnStuff.DesignPatterns.Singleton;

#region Singleton
var instance1 = Singleton.GetInstance();
var instance2 = Singleton.GetInstance();

if (instance1 == instance2)
{
    Console.WriteLine("Same Instance");
}

var balancer = Singleton.GetInstance();

// Load balance requests to a server - real world example of using singleton
const int numberOfRequests = 5;
for (var i = 0; i < numberOfRequests; i++)
{
    var server = balancer.NextServer;
    Console.WriteLine("Dispatch request to " + server.Name);
}
#endregion


