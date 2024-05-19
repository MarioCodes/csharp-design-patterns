using System;
using proxyPattern.Models.states;

namespace proxyPattern.Models
{
    public class GumballMachine : IGumballMachine
    {
        public IState _soldOutState {  get; set; }
        public IState _noQuarterState {  get; set; }
        public IState _hasQuarterState { get; set; }
        public IState _soldState { get; set; }

        // current state
        public IState _state {  get; set; }

        // current number of gumballs
        public int _count { get; set; } = 0;
        public string _location { get; set; }

        public GumballMachine(string location, int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);

            _count = numberGumballs;
            _state = numberGumballs > 0 ? _noQuarterState : _soldState;
            _location = location;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
        }

        public void ReleaseBall()
        {
            _state.Dispense();
        }

        public int GetCount()
        {
            return _count;
        }

        public string GetLocation()
        {
            return _location;
        }

        public IState GetState()
        {
            return _state;
        }
    }
}
