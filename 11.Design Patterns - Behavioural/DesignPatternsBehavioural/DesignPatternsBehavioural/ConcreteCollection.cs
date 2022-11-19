
using DesignPatternsBehavioural;

namespace IteratorDesignPattern
{
    public class ConcreteCollection : AbstractCollection
    {
        private List<Employee> listEmployees = new List<Employee>();

        public Iterator CreateIterator()=> new Iterator(this);
        
        public int Count
        {
            get { return listEmployees.Count; }
        }
        public void AddEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }

        public Employee GetEmployee(int indexPossition)
        {
            return listEmployees[indexPossition];
        }
    }
}
