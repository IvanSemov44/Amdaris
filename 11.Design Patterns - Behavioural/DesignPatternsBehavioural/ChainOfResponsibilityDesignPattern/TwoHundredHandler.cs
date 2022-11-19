

namespace ChainOfResponsibilityDesignPattern
{
    public class TwoHundredHandler : Handler
    {
        public override void dispatchRs(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 200;

            if (numberOfNotesToBeDispatched > 0)
            {
                if (numberOfNotesToBeDispatched > 1)
                {
                    Console.WriteLine(
                        $"{numberOfNotesToBeDispatched} Two hundred notes are dispatched by TwoHundredHadler");
                }
                else
                {
                    Console.WriteLine(
                       $"{numberOfNotesToBeDispatched} Two hundred note is dispatched by TwoHundredHadler");
                }
            }

            long pendingAmountToBeProccessed = requestedAmount % 200;

            if (pendingAmountToBeProccessed > 0)
            {
                rsHandler.dispatchRs(pendingAmountToBeProccessed);
            }
        }
    }
}
