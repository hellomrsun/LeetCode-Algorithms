using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;

namespace _557_Reverse_Words_in_a_String_III
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            var arr = s.ToCharArray();
            var stack = new Stack<char>();
            var sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
                if (arr[i] == ' ')
                {
                    while (stack.Count > 0)
                    {
                        sb.Append(stack.Pop());
                    }
                }
                else if (i == arr.Length - 1)
                {
                    sb.Append(" ");
                    while (stack.Count > 0)
                    {
                        sb.Append(stack.Pop());
                    }
                }
            }
            return sb.ToString().Trim();
        }
    }
}