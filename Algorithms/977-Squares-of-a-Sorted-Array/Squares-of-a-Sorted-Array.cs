using System;

namespace _977_Squares_of_a_Sorted_Array
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            int b = nums.Length - 1, e = 0;
            int[] arr = new int[nums.Length];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[b]) > Math.Abs(nums[e]))
                {
                    arr[i] = nums[b] * nums[b];
                    b--;
                }
                else
                {
                    arr[i] = nums[e] * nums[e];
                    e++;
                }
            }
            return arr;
        }
    }
}