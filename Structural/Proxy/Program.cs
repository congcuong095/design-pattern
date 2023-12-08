using Proxy;

internal class Program
{
    private static void Main(string[] args)
    {
        IRemote remote = new RemoteProxy();
        remote.TurnOn();
        Console.WriteLine("---------------------");
        remote.TurnOff();
    }
}