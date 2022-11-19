

namespace ChainOfResponsibilityDesignPattern
{
    public abstract class Handler
    {
        public Handler rsHandler;
        
        public void NextHandler(Handler rsHandler)
        {
            this.rsHandler = rsHandler;
        }
        public abstract void dispatchRs(long requestedAmount);
    }
}
