using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateBasic
{
    public abstract class EstateForLetting : Estate
    {
        public abstract void CreatePrice(decimal price);
    }
}
