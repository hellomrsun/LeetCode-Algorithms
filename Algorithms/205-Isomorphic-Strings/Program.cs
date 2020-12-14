using System;

namespace _205_Isomorphic_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsIsomorphic("ab", "aa"));
            Console.WriteLine(new Solution().IsIsomorphic("xyz", "xyz"));
            Console.WriteLine(new Solution().IsIsomorphic("aabbb", "xxyyy"));
        }
    }
}
