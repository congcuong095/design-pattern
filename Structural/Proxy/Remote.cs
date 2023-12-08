namespace Proxy;
public class Remote : IRemote
{
    public void TurnOff()
    {
        Console.WriteLine("Turn On");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turn Off");
    }
}
