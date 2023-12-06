using Builder;

CarBuilder carBuilder = new CarBuilder();

Car car = carBuilder
            .AddBrand("BMW")
            .AddEngine(new Engine("4 ky"))
            .Build();

Console.WriteLine(car.ToString());