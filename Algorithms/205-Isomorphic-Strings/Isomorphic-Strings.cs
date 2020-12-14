namespace _205_Isomorphic_Strings
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            int[] a = new int[256], b = new int[256];
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                if (a[s[i]] != b[t[i]]) return false;
                a[s[i]] = i + 1;
                b[t[i]] = i + 1;
            }
            return true;
        }
    }
}