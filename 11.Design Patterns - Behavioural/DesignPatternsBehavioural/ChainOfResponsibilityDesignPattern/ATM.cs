
namespace ChainOfResponsibilityDesignPattern
{
    public class ATM
    {
        private TwoThousandHandler twoThousand = new TwoThousandHandler();
        private FiveHundredHandler fiveHundred = new FiveHundredHandler();
        private TwoHundredHandler twoHundred = new TwoHundredHandler();
        private HundredHandler hundredHandler = new HundredHandler();

        public ATM()
        {
            twoThousand.NextHandler(fiveHundred);
            fiveHundred.NextHandler(twoHundred);
            twoHundred.NextHandler(hundredHandler);
        }

        public void withdraw(long requestedAmount)
        {
            twoThousand.dispatchRs(requestedAmount);
        }
    }
}
