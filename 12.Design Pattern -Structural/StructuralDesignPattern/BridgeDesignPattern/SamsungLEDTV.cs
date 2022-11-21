
namespace BridgeDesignPattern
{
    public class SamsungLEDTV : LEDTV
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"Setting channel number {channelNumber} on Samsung TV");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning Off: Samsung TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning On: Samsung TV");
        }
    }
}
