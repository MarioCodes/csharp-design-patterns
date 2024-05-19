using System;
using proxyPattern.Models;

namespace proxyPattern.Monitor
{
    public class GumballMonitor : IGumballMonitor
    {
        public IGumballMachine _machine;

        public GumballMonitor(IGumballMachine machine)
        {
            _machine = machine;
        }

        public void Report()
        {
            Console.WriteLine($"Gumball machine {_machine.GetLocation()}");
            Console.WriteLine($"current inventory {_machine.GetCount()} gumballs");
            Console.WriteLine($"current state {_machine.GetState()}");
        }
    }
}
