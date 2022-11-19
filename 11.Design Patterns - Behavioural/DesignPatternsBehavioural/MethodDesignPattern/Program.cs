using MethodDesignPattern;

Console.WriteLine("Build a Concrete House\n");

HouseTemplate houseTemplate = new ConcreteHouse();
houseTemplate.BuildHouse();
Console.WriteLine();

Console.WriteLine("Build a Wooden House\n");
houseTemplate = new WoodenHouse();

houseTemplate.BuildHouse();
Console.Read();