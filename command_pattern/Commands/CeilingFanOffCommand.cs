namespace commandPattern.Models
{
    public class CeilingFanOffCommand: ICommand
    {
        private CeilingFan _ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _ceilingFan.Off();
        }
    }
}
