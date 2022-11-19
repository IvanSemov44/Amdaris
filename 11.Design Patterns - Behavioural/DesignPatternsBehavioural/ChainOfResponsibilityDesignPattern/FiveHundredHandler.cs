
namespace ChainOfResponsibilityDesignPattern
{
    public class FiveHundredHandler : Handler
    {
        public override void dispatchRs(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 500;

            if (numberOfNotesToBeDispatched > 0)
            {
                if (numberOfNotesToBeDispatched > 1)
                {
                    Console.WriteLine(
                        $"{numberOfNotesToBeDispatched} Five Hundred notes are dispatched by FiveHundredHadler");
                }
                else
                {
                    Console.WriteLine(
                       $"{numberOfNotesToBeDispatched} Five Hundred note is dispatched by FiveHundredHadler");
                }
            }

            long pendingAmountToBeProccessed = requestedAmount % 500;

            if (pendingAmountToBeProccessed > 0)
            {
                rsHandler.dispatchRs(pendingAmountToBeProccessed);
            }
        }
    }
}
