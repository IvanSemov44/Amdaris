using System.Collections;
using System.Drawing;

namespace EstateBasic
{
    public class Estates : IEnumerable
    {
        private EstateForSell[] _estatesForSell;

        public Estates(EstateForSell[] estateForSell)
        {
            _estatesForSell = estateForSell;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public EstateEnum GetEnumerator()
        {
            return new EstateEnum(_estatesForSell);
        }
    }
}
