using System.Collections.Generic;

namespace _150_Evaluate_Reverse_Polish_Notation
{
    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            if (tokens == null || tokens.Length == 0) return 0;

            int len = tokens.Length;

            var numStack = new Stack<int>();

            for (int i = 0; i <= len - 1; i++)
            {
                var ope = tokens[i];

                if (ope == "+")
                {
                    numStack.Push(numStack.Pop() + numStack.Pop());
                }
                else if (ope == "-")
                {
                    var operand2 = numStack.Pop();
                    var operand1 = numStack.Pop();
                    numStack.Push(operand1 - operand2);
                }
                else if (ope == "*")
                {
                    numStack.Push(numStack.Pop() * numStack.Pop());
                }
                else if (ope == "/")
                {
                    var operand2 = numStack.Pop();
                    var operand1 = numStack.Pop();
                    numStack.Push(operand1 / operand2);
                }
                else
                {
                    numStack.Push(int.Parse(ope));
                }
            }

            return numStack.Pop();
        }
    }
}
