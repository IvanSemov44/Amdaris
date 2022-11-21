
using DecoratorDesignPattern;

ICar bmwCar1 = new BMWCar();
bmwCar1.ManufactureCar();
Console.WriteLine(bmwCar1+"\n");

DieselCarDecorator dcd = new DieselCarDecorator(bmwCar1);
dcd.ManufactureCar();

Console.WriteLine();

ICar bmwCar2 = new BMWCar();
PetrolCarDecorator pcd = new PetrolCarDecorator(bmwCar2);
pcd.ManufactureCar();
