using System;

namespace _1007_Minimum_Domino_Rotations_For_Equal_Row
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6] {2,1,2,4,2,2};
            int[] b = new int[6] {5,2,6,2,3,2};
            var r = new Solution().MinDominoRotations(a, b);
            Console.WriteLine("The minimum domino rotations is:" + r);
        }
    }
}
