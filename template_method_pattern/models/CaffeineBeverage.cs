using System;

namespace templateMethodPattern.models
{
    public abstract class CaffeineBeverage
    {
        // the methods that need to be supplied by a subclass are declared abstract
        protected abstract void Brew();
        protected abstract void AddCondiments();

        // this is the template method itself
        // BoilWater() and AddCondiments() is the same for both Coffee and Tea, so we only need to abstract the different
        //  methods Brew() and AddCondiments()
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
