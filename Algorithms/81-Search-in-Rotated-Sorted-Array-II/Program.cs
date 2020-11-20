using System;

namespace _81_Search_in_Rotated_Sorted_Array_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new int[3] { 3, 5, 1 };
            var res = new Solution().Search(arr1, 1);
            Console.WriteLine (res);

            var arr2 = new int[7] { 2, 5, 6, 0, 0, 1, 2 };
            var res2 = new Solution().Search(arr2, 3);
            Console.WriteLine (res2);
        }
    }
}
