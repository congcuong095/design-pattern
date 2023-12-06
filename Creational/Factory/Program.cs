using Factory.AbstractFactory;
using Factory.Fatory;

//Using Factory Method Pattern
//IAnimalFactory factory1 = new BasicAnimalFactory();
//IAnimalFactory factory2 = new RandomAnimalFactory();

IAnimalFactory factory;
Random random = new();
int index = random.Next(0, 2);

if (index == 0)
{
    factory = new FourLegsAnimalFactory();
}
else
{
    factory = new TwoLegsAnimalFactory();
}


Console.WriteLine(factory.CreateAnimal().SayName());
Console.WriteLine(factory.CreateAnimal().SayName());
Console.WriteLine(factory.CreateAnimal().SayName());
Console.WriteLine(factory.CreateAnimal().SayName());
Console.WriteLine(factory.CreateAnimal().SayName());
