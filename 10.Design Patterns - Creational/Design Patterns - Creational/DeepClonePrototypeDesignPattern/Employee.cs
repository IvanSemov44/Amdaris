

namespace DeepClonePrototypeDesignPattern
{
    public class Employee
    {
        public string? Name { get; set; }

        public string? Department { get; set; }

        public Address? EmpAddress { get; set; }



        public Employee GetClone()
        {
            Employee emp = (Employee)this.MemberwiseClone();
            emp.EmpAddress = EmpAddress.GetClone();
            return emp;
        
        }
    }
}
