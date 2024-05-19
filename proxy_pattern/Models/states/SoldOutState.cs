using System;

namespace proxyPattern.Models.states
{
    public class SoldOutState : IState
    {
        private GumballMachine _machine;

        public SoldOutState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed as there are no gumballs left");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Ejecting quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Insert quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Not possible to turn the crank. There are no gumballs left");
        }
    }
}
