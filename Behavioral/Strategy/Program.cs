using Strategy.Base;
using Strategy.Strategy;

Ticket ticket = new Ticket();
ticket.Name = "My ticket";
ticket.Price = 100;

ticket.SetStrategy(new HalfDiscountStrategy());

Console.WriteLine(ticket.Discount());
Console.WriteLine("----------------------------------");

ticket.SetStrategy(new QuarterDiscountStrategy());
Console.WriteLine(ticket.Discount());
