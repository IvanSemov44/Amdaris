namespace ArrayCollectionGeneric
{
    public class Collection<T>
    {

        private T[] _array = new T[4];
        private int _currentIndex = 0;

        public Collection()
        {

        }

        private void NewArray(int length)
        {
            T[] newArray = new T[length * 2];

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }


        public void Add(T item)
        {
            if (_currentIndex == _array.Length)
            {
                NewArray(_array.Length);
            }
            _array[_currentIndex] = item;

            _currentIndex++;
        }

        public void Remove(int index)
        {
            T[] newArray = new T[_array.Length];
            
            for(int i = 0; i < _array.Length; i++)
            {
                if(i != index)
                {
                    newArray[i] = _array[i];
                }
            }
            _array = newArray;
        }

        public T GetItemByIndex (int index)
        {
            return _array[index];
        }

        public void SetItemByIndex(int index,T item)
        {
            _array[index] = item;
        }

        public void SwapByIndexs(int firstIndex, int secondIndex)
        {
            var value = _array[firstIndex];
            Remove(firstIndex);
            _array[firstIndex] = _array[secondIndex];
            _array[secondIndex] = value;
        }

    }
}
