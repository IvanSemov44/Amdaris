using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateBasic
{
    public class EstateForLettingАpartment : EstateForLetting
    {
        public decimal PriceForMonth { get { return _price; } }
        public override void CreatePrice(decimal price)
        {
            this._price = price;
        }
    }
}
