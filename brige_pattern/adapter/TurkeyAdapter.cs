using adapterPattern.duck;
using adapterPattern.turkey;

namespace adapterPattern.adapter
{
    public class TurkeyAdapter : Duck
    {
        private readonly Turkey _turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            _turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                // turkeys can only fly in short distances
                _turkey.Fly();
            }
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
