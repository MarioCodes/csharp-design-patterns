using System.Collections.Generic;
using compositePattern.nodes.abstraction;

namespace compositePattern.nodes
{
    // represents the complex components that may have children. usually they delegate the work to their children and then "sum-up" the result
    public class Node : Component
    {
        public List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        // recursive op. A node iterates all its children, collecting and summing their results. The whole object tree is traversed as a result
        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach(Component component in _children)
            {
                result += component.Operation();
                if(i != _children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }
    }
}
