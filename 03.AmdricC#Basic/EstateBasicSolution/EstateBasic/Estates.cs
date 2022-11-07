using System.Collections;
using System.Drawing;

namespace EstateBasic
{
    public class Estates : IEnumerable
    {
        private EstateForSell[] _estatesForSell;

        public Estates(EstateForSell[] estateForSell)
        {
            _estatesForSell = new EstateForSell[estateForSell.Length];

            for (int i = 0; i < estateForSell.Length; i++)
            {
                _estatesForSell[i] = estateForSell[i];
            }
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
