using System;

namespace proxyPattern.Models.states
{
    public class NoQuarterState : IState
    {
        private GumballMachine _machine;

        public NoQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Just inserted a quarter into the machine");
            _machine._state = _machine._hasQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning the crank for first time");
        }
    }
}
