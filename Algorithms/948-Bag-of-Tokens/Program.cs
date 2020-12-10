using System;

namespace _948_Bag_of_Tokens
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] {100,200,300,400};
            var res = new Solution().BagOfTokensScore(arr, 200);
            Console.WriteLine(res);
        }
    }
}
