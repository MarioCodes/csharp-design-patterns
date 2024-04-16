using compositePattern.nodes.abstraction;

namespace compositePattern.nodes
{
    // a leaf represents the end object of a composition. A leaf can't have any children. Usually it does the actual work; Nodes just delegate to their sub-components;
    public class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsNode()
        {
            return false;
        }
    }
}
