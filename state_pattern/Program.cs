using System;
using statePattern.Models;

namespace statePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IGumballMachine machine = new GumballMachine(1);
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.ReleaseBall();

            Console.WriteLine();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.ReleaseBall();
            machine.EjectQuarter();
        }

    }
}
