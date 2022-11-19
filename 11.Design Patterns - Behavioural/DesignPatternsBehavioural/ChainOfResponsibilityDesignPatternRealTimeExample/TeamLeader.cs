

namespace ChainOfResponsibilityDesignPatternRealTimeExample
{
    public class TeamLeader : Employee
    {
        private int MAX_LEAVES_CAN_APPROVE = 10;

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
            Console.WriteLine($"TeamLeader approved {numberOfDaysLeave} days Leave for employee: {employeeName}");
        }
    }
}
