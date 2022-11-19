

namespace ChainOfResponsibilityDesignPatternRealTimeExample
{
    class HR : Employee
    {

        private int MAX_LEAVES_CAN_APPROVE = 30;

        public override void ApplyLeave(string employeeName, int numberOfDaysLeave)
        {
            if (numberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                ApproveLeaves(employeeName, numberOfDaysLeave);
            }
            else
            {
                Console.WriteLine("Leave application suspended, Please contact HR");
            }
        }

        private void ApproveLeaves(string employeeName, int numberOfDaysLeave)
        {
            Console.WriteLine($"HR approved {numberOfDaysLeave} days Leave for employee: {employeeName}");
        }
    }
}
