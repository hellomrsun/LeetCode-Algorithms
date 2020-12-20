using System.Text;

namespace _880_Decoded_String_at_Index
{
    public class Solution
    {
        public string DecodeAtIndex(string S, int K)
        {
            long n = 0;
            int i = 0;
            for (i = 0; n < K; i++)
            {
                if (char.IsDigit(S[i]))
                {
                    n *= (S[i] - '0');
                }
                else
                {
                    n = n + 1;
                }
            }

            while (i-- > 0)
            {
                if (char.IsDigit(S[i]))
                {
                    n /= (S[i] - '0');
                    K %= (int)n;
                }
                else if (K % n-- == 0)
                {
                    return S[i].ToString();
                }
            }
            return "";
        }
    }
}