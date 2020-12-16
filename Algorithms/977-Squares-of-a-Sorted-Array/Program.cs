using System;

namespace _977_Squares_of_a_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[5]{-4,-1,0,3,10};
            var res = new Solution().SortedSquares(arr);
            Console.WriteLine(string.Join(",", res));
        }
    }
}
