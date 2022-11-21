﻿namespace DecoratorDesignPattern
{
    public class CarDecorator : ICar
    {
        protected ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual ICar ManufactureCar()
        {
            return car.ManufactureCar();
        }
    }
}
