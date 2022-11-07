using System.Collections;

namespace EstateBasic
{
    public class EstateEnum : IEnumerator
    {

        private EstateForSell[] _estate;
        int position = -1;

        public EstateEnum(EstateForSell[] estate)
        {
            _estate = estate;
        }



        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public EstateForSell Current

        {
            get
            {
                try
                {
                    return _estate[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


        public bool MoveNext()
        {
            position++;
            return (position < _estate.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}