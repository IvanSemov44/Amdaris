
namespace ChainOfResponsibilityDesignPatternRealTimeExample
{
     class ProjectLeader : Employee
    {
        private int MAX_LEAVES_CAN_APPROVE = 20;

        public override void ApplyLeave(string employeeName, int numberOfDaysLeave)
        {
            if (numberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                ApproveLeaves(employeeName, numberOfDaysLeave);
            }
            else
            {
                supervisor.ApplyLeave(employeeName, numberOfDaysLeave);
            }
        }

        private void ApproveLeaves(string employeeName, int numberOfDaysLeave)
        {
            Console.WriteLine($"ProjectLeader approved {numberOfDaysLeave} days Leave for employee: {employeeName}");
        }
    }
}
