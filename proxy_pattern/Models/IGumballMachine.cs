using proxyPattern.Models.states;

namespace proxyPattern.Models
{
    public interface IGumballMachine
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void ReleaseBall();
        int GetCount();
        string GetLocation();
        IState GetState();
    }
}
