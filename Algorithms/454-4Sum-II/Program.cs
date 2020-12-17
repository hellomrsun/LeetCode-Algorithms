using System;

namespace _454_4Sum_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new Solution().FourSumCount(
                new int[2]{1, 2}, new int[2]{-2, -1}, new int[2]{-1, 2}, new int[2]{0, 2});
            Console.WriteLine(res);
        }
    }
}
