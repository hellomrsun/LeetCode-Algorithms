using System;

namespace _3_Longest_Substring_Without_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "abcabcbb";
            var res = new Solution().LengthOfLongestSubstring(str);
            Console.WriteLine("Result is:" + res);
        }
    }
}
