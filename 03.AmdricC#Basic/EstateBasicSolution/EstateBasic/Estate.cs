using EstateBasic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateBasic
{
    public class Estate : IEstate
    {
        public string? Location { get; set; }
        public int Price { get; set; }
    }
}
