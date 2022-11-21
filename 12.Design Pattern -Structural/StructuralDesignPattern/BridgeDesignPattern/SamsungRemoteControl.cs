
namespace BridgeDesignPattern
{
    public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(LEDTV ledTV) : base(ledTV)
        {

        }

        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }

        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }

        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
    }
}
