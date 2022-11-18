namespace FluentInterfaceDesignPattern
{
    public class FluentEmployee
    {
        private Employee employee = new Employee();

        public FluentEmployee Name(string Name)
        {
            employee.Name = Name;
            return this;
        }

        public FluentEmployee Born(string DateOfBirth)
        {
            employee.DateOfBirth =Convert.ToDateTime(DateOfBirth);
            return this;
        }

        public FluentEmployee WorkingOn(string Department)
        {
            employee.Department = Department;
            return this;
        }

        public FluentEmployee StayAt(string Address)
        {
            employee.Address = Address;
            return this;
        }
    }
}
