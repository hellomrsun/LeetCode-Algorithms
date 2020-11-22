using System;

namespace _150_Evaluate_Reverse_Polish_Notation
{
    class Program
    {
        static void Main(string[] args)
        {
            var rpn1 = new string[]{"2", "1", "+", "3", "*"};
            var res1 = new Solution().EvalRPN(rpn1);
            Console.WriteLine(res1); //9

            var rpn2 = new string[]{"4", "13", "5", "/", "+"};
            var res2 = new Solution().EvalRPN(rpn2);
            Console.WriteLine(res2); //6

            var rpn3 = new string[]{"10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"};
            var res3 = new Solution().EvalRPN(rpn3);
            Console.WriteLine(res3); //22
        }
    }
}
