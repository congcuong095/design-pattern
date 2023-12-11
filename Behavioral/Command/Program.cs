using Command;

Fan fan = new Fan();
ICommand turnOn = new TurnOnCommand(fan);
ICommand turnOff = new TurnOffCommand(fan);
Remote remote = new Remote(turnOn, turnOff);

remote.ClickTurnOn();
remote.ClickTurnOn();
remote.ClickTurnOff();