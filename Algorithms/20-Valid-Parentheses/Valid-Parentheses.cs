using System.Collections.Generic;

namespace _20_Valid_Parentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s == null || s.Length == 0 || s.Length % 2 == 1) return false;
            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(')');
                }
                else if (s[i] == '{')
                {
                    stack.Push('}');
                }
                else if (s[i] == '[')
                {
                    stack.Push(']');
                }
                else if (stack.Count == 0 || stack.Peek() != s[i])
                {
                    return false;
                }
                else{
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
    }
}