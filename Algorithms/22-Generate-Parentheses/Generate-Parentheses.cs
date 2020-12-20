using System.Collections.Generic;
using System;

namespace _22_Generate_Parentheses
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var res = new List<string>();

            BackTrack(res, "", 0, 0, n);

            return res;
        }

        private void BackTrack(List<string> list, string str, int open, int close, int max)
        {
            if (str.Length == max * 2)
            {
                list.Add(str);
                return;
            }

            if (open < max)
            {
                BackTrack(list, str + "(", open + 1, close, max);
            }
            if (close < open)
            {
                BackTrack(list, str + ")", open, close + 1, max);
            }
        }
    }
}