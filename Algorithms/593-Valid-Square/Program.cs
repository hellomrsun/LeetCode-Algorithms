using System;

namespace _593_Valid_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = new int[2]{0,0}, p2 = new int[2]{1,1}, p3 = new int[2]{1,0}, p4 = new int[2]{0,1};
            var res = new Solution().ValidSquare(p1, p2, p3, p4);
            Console.WriteLine(res);
        }
    }
}
