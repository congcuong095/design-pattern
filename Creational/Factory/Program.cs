using Factory.Fatory;

IAnimalFactory factory;
Random random = new();
int index = random.Next(0, 2);

if (index == 0)
{
    factory = new BasicAnimalFactory();
}
else
{
    factory = new RandomAnimalFactory();
}


Console.WriteLine(factory.CreateAnimal().SayName());
Console.WriteLine(factory.CreateAnimal().SayName());
Console.WriteLine(factory.CreateAnimal().SayName());
Console.WriteLine(factory.CreateAnimal().SayName());
Console.WriteLine(factory.CreateAnimal().SayName());
