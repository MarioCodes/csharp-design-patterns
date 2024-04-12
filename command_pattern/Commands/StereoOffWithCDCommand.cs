namespace commandPattern.Models
{
    public class StereoOffWithCDCommand : ICommand
    {
        private Stereo _stereo;

        public StereoOffWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
        }
    }
}