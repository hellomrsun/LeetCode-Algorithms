using System;

namespace _20_Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("() is valid: " + new Solution().IsValid("()"));
            Console.WriteLine("(] is valid: " +new Solution().IsValid("(]"));
            Console.WriteLine("(){}[] is valid: " +new Solution().IsValid("(){}[]"));
            Console.WriteLine("(( is valid: " +new Solution().IsValid("(("));
        }
    }
}
