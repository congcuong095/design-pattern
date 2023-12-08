namespace Proxy;
public class RemoteProxy : IRemote
{
    private Remote? remote;
    public void TurnOff()
    {
        Console.WriteLine("Wrapee " + remote);
        remote ??= new Remote();
        remote.TurnOff();
    }

    public void TurnOn()
    {
        Console.WriteLine("Wrapee " + remote);
        remote ??= new Remote();
        remote.TurnOn();
    }
}
