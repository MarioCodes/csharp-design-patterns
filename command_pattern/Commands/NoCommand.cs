using System;

namespace commandPattern.Models
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("no command set");
        }
    }
}