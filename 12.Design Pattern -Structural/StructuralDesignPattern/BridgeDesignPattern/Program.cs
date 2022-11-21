
using BridgeDesignPattern;

SonyRemoteControl sonyRemote = new SonyRemoteControl(new SonyLEDTV());
sonyRemote.SwitchOn();
sonyRemote.SetChannel(101);
sonyRemote.SwitchOff();

Console.WriteLine();

SamsungRemoteControl samsungRemote = new SamsungRemoteControl(new SamsungLEDTV());
samsungRemote.SwitchOn();
samsungRemote.SetChannel(292);
samsungRemote.SwitchOff();