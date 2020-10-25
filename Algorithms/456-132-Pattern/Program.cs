using System;

namespace _456_132_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[5] { 3, 5, 0, 3, 4 };
            var result = new Solution().Find132pattern(arr);
            Console.WriteLine($"{string.Join(",", arr)} is 132 pattern?:{result}");

            var arr2 = new int[8] { 5, 6, 7, 10, 9, 12, 13, 14 };
            var result2 = new Solution().Find132pattern(arr2);
            Console.WriteLine($"{string.Join(",", arr2)} is 132 pattern?:{result2}");
        }
    }
}
