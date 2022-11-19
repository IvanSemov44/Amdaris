

namespace ChainOfResponsibilityDesignPattern
{
    public class TwoThousandHandler : Handler
    {
        public override void dispatchRs(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 2000;

            if (numberOfNotesToBeDispatched > 0)
            {
                if (numberOfNotesToBeDispatched > 1)
                {
                    Console.WriteLine(
                        $"{numberOfNotesToBeDispatched} Two thousand notes are dispatched by TwoThousandHadler");
                }
                else
                {
                    Console.WriteLine(
                       $"{numberOfNotesToBeDispatched} Two thousand note is dispatched by TwoThousandHadler");
                }
            }

            long pendingAmountToBeProccessed = requestedAmount % 2000;

            if (pendingAmountToBeProccessed > 0)
            {
                rsHandler.dispatchRs(pendingAmountToBeProccessed);
            }
        }
    }
}
