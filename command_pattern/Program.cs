using commandPattern.Client;
using commandPattern.Models;

namespace commandPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            Light livingRoomLight = new Light("Living room");
            Light kitchenLight = new Light("kitchen");
            CeilingFan ceilingFan = new CeilingFan("living room");
            GarageDoor garageDoor = new GarageDoor("");
            Stereo stereo = new Stereo("living room");

            // light commands
            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);
            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);

            // ceiling fan commands
            var ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            // garage door commands
            var garageDoorUp = new GarageDoorUpCommand(garageDoor);
            var garageDoorDown = new GarageDoorDownCommand(garageDoor);

            // stereo
            var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            var stereoOffWithCD = new StereoOffWithCDCommand(stereo);

            // load commands into remote programmable remote control slots
            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remote.SetCommand(3, stereoOnWithCD, stereoOffWithCD);

            // push buttons
            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);

            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);

            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);

            remote.OnButtonWasPushed(3);
            remote.OffButtonWasPushed(3);
        }

    }
}
