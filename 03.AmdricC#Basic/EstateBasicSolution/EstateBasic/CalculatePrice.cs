using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateBasic
{
    internal static class CalculatePrice
    {
        public static decimal TotalPrice(decimal price, int meters)
        {
            return price * meters;
        }
    }
}
