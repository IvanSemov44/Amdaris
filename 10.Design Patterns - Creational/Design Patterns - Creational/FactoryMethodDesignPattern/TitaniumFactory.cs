using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct() => new Titanium();
    }
}
