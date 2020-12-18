namespace _334_Increasing_Triplet_Subsequence
{
    public class Solution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int s = int.MaxValue, b = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                var ith = nums[i];
                if (ith <= s) s = ith;
                else if (ith <= b) b = ith;
                else return true;
            }
            return false;
        }
    }
}