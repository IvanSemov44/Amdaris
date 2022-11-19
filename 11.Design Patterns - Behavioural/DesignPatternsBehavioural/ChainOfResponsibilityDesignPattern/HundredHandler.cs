
namespace ChainOfResponsibilityDesignPattern
{
    public class HundredHandler : Handler
    {
        public override void dispatchRs(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 100;

            if (numberOfNotesToBeDispatched > 0)
            {
                if (numberOfNotesToBeDispatched > 1)
                {
                    Console.WriteLine(
                        $"{numberOfNotesToBeDispatched} Hundred notes are dispatched by Hadler");
                }
                else
                {
                    Console.WriteLine(
                       $"{numberOfNotesToBeDispatched} Hundred note is dispatched by HundredHadler");
                }
            }

            long pendingAmountToBeProccessed = requestedAmount % 100;

            if (pendingAmountToBeProccessed > 0)
            {
                rsHandler.dispatchRs(pendingAmountToBeProccessed);
            }
        }
    }
}
