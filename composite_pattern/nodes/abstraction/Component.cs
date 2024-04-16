using System;

namespace compositePattern.nodes.abstraction
{
    // base component. declares common operations for both simple and complex objects
    public abstract class Component
    {
        public Component() { }

        public abstract string Operation();

        // in some cases you may leave this and write a default implementation here
        public virtual void Add(Component component) 
        {
            throw new NotImplementedException();
        }

        // in some cases you may leave this and write a default implementation here
        public virtual void Remove(Component component) 
        {
            throw new NotImplementedException();
        }

        public virtual bool IsNode()
        {
            return true;
        }
    }
}
