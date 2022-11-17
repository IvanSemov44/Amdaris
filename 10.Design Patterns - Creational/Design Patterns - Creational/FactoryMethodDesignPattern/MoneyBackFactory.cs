using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct() => new MoneyBack();

    }
}
