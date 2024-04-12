using commandPattern.Models;

namespace commandPattern.Client
{
    public class RemoteControl
    {
        ICommand[] _onCommands;
        ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = new NoCommand();
                _offCommands[i] = new NoCommand();
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }
    }
}
