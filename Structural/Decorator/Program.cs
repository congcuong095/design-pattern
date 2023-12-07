using Decorator.Base;
using Decorator.Product;

var MyOrder = new PuddingMilkTea(new EggMilkTea(new BubbleMilkTea(new MilkTea())));

Console.WriteLine(MyOrder.Count());