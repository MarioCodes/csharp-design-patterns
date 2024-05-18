namespace statePattern.Models
{
    public interface IGumballMachine
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void ReleaseBall();
    }
}
