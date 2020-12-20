using System;

namespace _22_Generate_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new Solution().GenerateParenthesis(3);
            Console.WriteLine(string.Join(",", res));
        }
    }
}
