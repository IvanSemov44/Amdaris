
namespace BuilderDesignPatterRealTimeExample
{
    public abstract class BeverageBuilder
    {
        protected Beverage beverage;

        public void CreateBeverage() => beverage = new Beverage();


        public Beverage GetBeverage() => beverage;

        public abstract void SetBeverageType();
        public abstract void SetMilk();
        public abstract void SetSugar();
        public abstract void SetWater();
        public abstract void SetPowderQuentity();

    }
}
