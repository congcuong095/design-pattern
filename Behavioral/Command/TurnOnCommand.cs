namespace Command;
public class TurnOnCommand : ICommand
{
    private readonly Fan fan;

    public TurnOnCommand(Fan _fan)
    {
        fan = _fan;
    }
    public void Excute()
    {
        fan.TurnOn();
    }

    public void Undo()
    {
        fan.TurnOff();
    }
}
