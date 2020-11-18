using System;

namespace _845_Longest_Mountain_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[7] { 2, 1, 4, 7, 3, 2, 5 };
            var res = new Solution().LongestMountain(input);
            Console.WriteLine(res);
        }
    }
}
