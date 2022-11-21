
namespace DecoratorDesignPattern
{
    public class BMWCar : ICar
    {
        private string CarName = "BMW";

        public string CarBody { get; set; }
        public string CarDoors { get; set; }

        public string CarWheels { get; set; }

        public string CarGlass { get; set; }

        public string Engine { get; set; }

        public override string ToString()
        {
            return $"BMWCar [CarName={CarName}, CarBody={CarBody}, CarDoors={CarDoors}, CarWheels={CarWheels}, CarGlass={CarGlass}, Engine={Engine}]";
        }

        public ICar ManufactureCar()
        {
            CarBody = "carbon fiber material";
            CarDoors = "4 car doors";
            CarWheels = "4 MRF wheels";
            CarGlass = "6 car glasses";
            return this;
        }
    }
}
