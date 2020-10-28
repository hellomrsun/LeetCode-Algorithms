using System;

namespace _228_Summary_Ranges
{
    class Program
    {
        static void Main(string[] args)
        {
            // var nums = new int[6]{0,1,2,4,5,7};
            // var res = new Solution().SummaryRanges(nums);
            // Console.WriteLine($"The result is {string.Join(",", res)}");

            var nums2 = new int[6] {0,1,2,4,5,7};
            var res2 = new Solution().SummaryRanges(nums2);
            Console.WriteLine($"The result is {string.Join(",", res2)}");
        }
    }
}
