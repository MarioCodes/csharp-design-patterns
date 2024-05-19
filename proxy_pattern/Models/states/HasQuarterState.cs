using System;

namespace proxyPattern.Models.states
{
    public class HasQuarterState : IState
    {
        private GumballMachine _machine;

        public HasQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _machine._state = _machine._noQuarterState;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            _machine._state = _machine._soldState;
        }
    }
}
