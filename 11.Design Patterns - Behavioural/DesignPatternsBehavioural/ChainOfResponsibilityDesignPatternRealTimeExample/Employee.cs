

namespace ChainOfResponsibilityDesignPatternRealTimeExample
{
    public abstract class Employee
    {
        protected Employee supervisor;

        public void SetNextSupervisor(Employee supervisor)
        {
            this.supervisor = supervisor;
        }

        public abstract void ApplyLeave(string employeeName,int numberOfDaysLeave);
    }
}
