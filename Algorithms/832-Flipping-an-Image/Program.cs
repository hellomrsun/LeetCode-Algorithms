using System;

namespace _832_Flipping_an_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3][]{
                new int[3] {1,1,0},
                new int[3] {1,0,1},
                new int[3] {0,0,0},
            };
            var result = new Solution().FlipAndInvertImage(arr);
            Console.WriteLine(result);
        }
    }
}
