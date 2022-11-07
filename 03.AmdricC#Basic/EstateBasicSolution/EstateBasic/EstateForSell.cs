using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateBasic
{
    public class EstateForSell : Estate , ICloneable
    {
        private decimal _squereMeter;
        private decimal _totalPrice;


        public decimal TotalPrice { get { return _totalPrice; } }
        public decimal SquareMeter { set { _squereMeter = value; } }

        public object Clone()
        {
            EstateForSell estateForSell = new EstateForSell();
            estateForSell.SquareMeter = 200;
            return estateForSell.TotalPrice;
        }

        public virtual void CreatePrice(decimal price,int meters)
        {
            _totalPrice = CalculatePrice.TotalPrice(price, meters);
        }
    }
}
