using System.Collections.Generic;
using System;

namespace _3_Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int i = 0, j = 0, max = 0;
            HashSet<char> set = new HashSet<char>();

            while (j < s.Length)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    j++;
                    max = Math.Max(max, set.Count);
                }
                else
                {
                    set.Remove(s[i]);
                    i++;
                }
            }

            return max;
        }
    }
}