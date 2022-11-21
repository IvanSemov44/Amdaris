
namespace BridgeDesignPattern
{
    public class SonyLEDTV : LEDTV
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"Setting channel number {channelNumber} Sony TV");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF: Sony TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning On: Sony TV");
        }
    }
}
