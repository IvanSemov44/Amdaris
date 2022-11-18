using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatterRealTimeExample
{
    public class CoffeeBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            Console.WriteLine("Coffee");
            GetBeverage().BeverageName = "Coffee";
        }

        public override void SetMilk()
        {
            Console.WriteLine("Step 2: Adding Milk");
            GetBeverage().Milk = 50;
        }

        public override void SetPowderQuentity()
        {
            Console.WriteLine("Step 4: Adding 15 gm of coffee powder");
            GetBeverage().PowderQuantity = 15;
        }

        public override void SetSugar()
        {
            Console.WriteLine("Step 3: Adding Sugar");
            GetBeverage().Sugar = 10;
        }

        public override void SetWater()
        {
            Console.WriteLine("Step 1: Boiling Water");
            GetBeverage().Water = 40;
        }
    }
}
