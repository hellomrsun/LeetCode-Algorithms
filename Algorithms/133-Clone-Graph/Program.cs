using System;
using System.Collections.Generic;

namespace _133_Clone_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            var neighbours = new List<Node>{
                new Node(2, new List<Node>{ new Node(3)}),
                new Node(4, new List<Node>{ new Node(5)}),
            };
            var node = new Node(1, neighbours);
            var clonedNode = new Solution().CloneGraph(node);
            Console.WriteLine("cloned graph is:" + clonedNode.val);
        }
    }
}
