namespace Command;
public class Remote
{
    private readonly ICommand turnOnCommand;
    private readonly ICommand turnOffCommand;

    public Remote(ICommand _turnOnCommand, ICommand _turnOffCommand)
    {
        turnOffCommand = _turnOffCommand;
        turnOnCommand = _turnOnCommand;
    }

    public void ClickTurnOn()
    {
        turnOnCommand.Excute();
    }

    public void ClickTurnOff()
    {
        turnOffCommand.Excute();
    }
}
