namespace Builder;
public interface ICarBuilder
{
    CarBuilder AddWheel(Wheel wheel);
    CarBuilder AddEngine(Engine engine);
    CarBuilder AddWindscreen(Windscreen windscreen);
    CarBuilder AddBrand(string brand);

    Car Build();
}
