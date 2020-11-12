using System;

namespace _47_Permutations_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3] {1, 1, 2};
            var res = new Solution().PermuteUnique(arr);
            Console.WriteLine(res.Count);
        }
    }
}
