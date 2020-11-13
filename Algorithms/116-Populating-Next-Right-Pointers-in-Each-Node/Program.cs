using System;

namespace _116_Populating_Next_Right_Pointers_in_Each_Node
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new Node(1, new Node(2, new Node(4), new Node(5), null), new Node(3, new Node(6), new Node(7), null), null);
            var res = new Solution().Connect(node);
            Console.WriteLine(res);
        }
    }
}
