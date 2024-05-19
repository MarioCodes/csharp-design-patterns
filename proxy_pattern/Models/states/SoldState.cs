using System;

namespace proxyPattern.Models.states
{
    public class SoldState : IState
    {
        private GumballMachine _machine;

        public SoldState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void Dispense()
        {
            Console.WriteLine("Dispense gumball");
            _machine._count--;
            if (_machine._count > 0)
            {
                _machine._state = _machine._noQuarterState;
            } else
            {
                Console.WriteLine("out of gumballs");
                _machine._state = _machine._soldOutState;
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }
    }
}
