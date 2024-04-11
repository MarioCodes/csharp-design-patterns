namespace commandPattern.Models
{
    public class SimpleRemoteControl
    {
        private Command _slot;

        public SimpleRemoteControl() { }

        public void SetCommand(Command command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}
