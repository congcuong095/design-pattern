namespace Command;
public class TurnOffCommand : ICommand
{
    private readonly Fan fan;

    public TurnOffCommand(Fan _fan)
    {
        fan = _fan;
    }
    public void Excute()
    {
        fan.TurnOff();
    }

    public void Undo()
    {
        fan.TurnOn();
    }
}
