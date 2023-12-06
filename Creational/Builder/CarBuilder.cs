namespace Builder;
public class CarBuilder : ICarBuilder
{
    public Engine? Engine { get; set; }
    public Wheel? Wheel { get; set; }
    public Windscreen? Windscreen { get; set; }

    public string? Brand { get; set; }

    public CarBuilder AddBrand(string brand)
    {
        Brand = brand;
        return this;
    }

    public CarBuilder AddEngine(Engine engine)
    {
        Engine = engine;
        return this;
    }

    public CarBuilder AddWheel(Wheel wheel)
    {
        Wheel = wheel;
        return this;
    }

    public CarBuilder AddWindscreen(Windscreen windscreen)
    {
        Windscreen = windscreen;
        return this;
    }

    public Car Build()
    {
        return new Car(Engine, Wheel, Windscreen, Brand);
    }
}
