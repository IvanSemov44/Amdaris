
using BuilderDesignPatterRealTimeExample;

Beverage beverage;
BeverageDirector beverageDirector = new BeverageDirector();

TeaBuilder tea = new TeaBuilder();
beverage = beverageDirector.MakeBeverage(tea);
Console.WriteLine(beverage.ShowBeverage());

Console.WriteLine("-------");

CoffeeBuilder coffe = new CoffeeBuilder();
beverage = beverageDirector.MakeBeverage(coffe);
Console.WriteLine(beverage.ShowBeverage());