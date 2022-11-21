
namespace DecoratorDesignPattern
{
    public class DieselCarDecorator : CarDecorator
    {

        public DieselCarDecorator(ICar car) : base(car)
        {
        }

        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;

        }

        public void AddEngine(ICar car)
        {
            if(car is BMWCar)
            {
                BMWCar bmvCar = (BMWCar)car;
                bmvCar.Engine = "Diesel Engine";
                Console.WriteLine($"DieselCarDecorator added diesel engine to the Car:{car}");
            }
        }
    }
}
