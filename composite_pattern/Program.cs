
using compositePattern.nodes;
using compositePattern.nodes.abstraction;
using System;

namespace compositePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component: ");
            ClientCode(leaf);

            var tree = new Node();
            var branch1 = new Node();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());

            var branch2 = new Node();
            branch2.Add(new Leaf());

            tree.Add(branch1);
            tree.Add(branch2);

            Console.WriteLine("Client: Now I've got a composite tree: ");
            ClientCode(tree);

            Console.WriteLine("Client: I don't need to check the component classes even when managing the tree:");
            ClientCode2(tree, leaf);
        }

        private static void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }

        private static void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsNode())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}");
        }
    }
}
