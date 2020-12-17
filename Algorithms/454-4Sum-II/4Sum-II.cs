using System;
using System.Collections.Generic;

namespace _454_4Sum_II
{
    public class Solution
    {
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    int sum = A[i] + B[j];
                    if (dict.ContainsKey(sum))
                    {
                        dict[sum]++;
                    }
                    else
                    {
                        dict.Add(sum, 1);
                    }
                }
            }

            var res = 0;

            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < D.Length; j++)
                {
                    int sum = -(C[i] + D[j]);
                    if (dict.ContainsKey(sum))
                    {
                        res += dict[sum];
                    }
                }
            }

            return res;
        }
    }
}