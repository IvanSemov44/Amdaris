using DesignPatternsBehavioural;

namespace IteratorDesignPattern
{
    public class Iterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;

        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;

        }

        public bool IsCompleted
        {
            get
            {
                return current >= collection.Count;
            }
        }

        public Employee First()
        {
            current = 0;
            return collection.GetEmployee(current);
        }

        public Employee Next()
        {
            current += step;
            if (!IsCompleted)
                return collection.GetEmployee(current);
            else
                return null;
        }
    }
}
