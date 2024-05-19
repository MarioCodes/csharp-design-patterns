using System;
using proxyPattern.Models;
using proxyPattern.Monitor;

namespace proxyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IGumballMachine machine = new GumballMachine("albacete", 5);
            machine.InsertQuarter();
            machine.TurnCrank();

            IGumballMonitor monitor = new GumballMonitor(machine);
            monitor.Report();

            machine.ReleaseBall();
        }

    }
}
