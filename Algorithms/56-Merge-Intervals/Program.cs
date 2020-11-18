using System;
using System.Collections.Generic;

namespace _56_Merge_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var input =
                new int[4][]
                {
                    new int[2] { 1, 3 },
                    new int[2] { 2, 6 },
                    new int[2] { 8, 10 },
                    new int[2] { 15, 18 }
                };

            var res = new Solution().Merge(input);

            var list = new List<string>();
            foreach (int[] item in res)
            {
                list.Add("[" + item[0] + "," + item[1] + "]");
            }

            Console.WriteLine(string.Join(",", list));
        }
    }
}
