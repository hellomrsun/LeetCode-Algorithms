using System;

namespace _80_Remove_Duplicates_from_Sorted_Array_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[6] { 1, 1, 1, 2, 2, 3 };
            var res = new Solution().RemoveDuplicates(arr);
            Console.WriteLine(res);

            var arr2 = new int[9] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            var res2 = new Solution().RemoveDuplicates(arr2);
            Console.WriteLine(res2);
        }
    }
}
