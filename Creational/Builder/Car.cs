namespace Builder;
public class Car
{
    public Engine? Engine { get; set; }
    public Wheel? Wheel { get; set; }
    public Windscreen? Windscreen { get; set; }

    public string? Brand { get; set; }

    public Car(Engine? engine, Wheel? wheel, Windscreen? windscreen, string? brand)
    {
        Engine = engine;
        Wheel = wheel;
        Windscreen = windscreen;
        Brand = brand;
    }

    public override string ToString()
    {
        return $"Car: Brand - {Brand}, Engine - {Engine?.Name}, Wheel - {Wheel?.Name}, Windscreen - {Windscreen?.Name}";
    }
}
