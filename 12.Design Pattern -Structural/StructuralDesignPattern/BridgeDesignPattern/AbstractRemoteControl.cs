
namespace BridgeDesignPattern
{
    public abstract class AbstractRemoteControl
    {
        protected LEDTV ledTv;

        public AbstractRemoteControl(LEDTV ledTv)
        {
            this.ledTv = ledTv;
        }

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
