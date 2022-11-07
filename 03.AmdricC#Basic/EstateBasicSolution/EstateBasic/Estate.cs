using EstateBasic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateBasic
{
    public abstract class Estate : IEstate
    {
        protected decimal _price;

        public string? Owner { get; set; }

        public string? Location { get; set; }
        public decimal Price { set { _price = value; } }

        
    }
}
