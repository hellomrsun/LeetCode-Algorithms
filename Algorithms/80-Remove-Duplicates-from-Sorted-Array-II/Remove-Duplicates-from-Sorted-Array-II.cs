namespace _80_Remove_Duplicates_from_Sorted_Array_II
{
    public class Solution
    {
        private int position = int.MinValue;
        private int prev = int.MinValue;
        private int pprev = int.MinValue;
        private int totalToDelete = 0;

        public int RemoveDuplicates(int[] nums)
        {
            position = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (prev == pprev && prev == nums[i])
                {
                    totalToDelete++;
                }
                else
                {
                    nums[position] = nums[i];
                    position++;
                    pprev = prev;
                    prev = nums[i];
                }
            }

            return nums.Length - totalToDelete;
        }
    }
}
