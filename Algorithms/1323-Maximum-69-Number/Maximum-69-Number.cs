namespace _1323_Maximum_69_Number
{
    public class Solution
    {
        public int Maximum69Number(int num)
        {
            var s = num.ToString();
            var arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != '9')
                {
                    arr[i] = '9';
                    break;
                }
            }
            return int.Parse(new string(arr));
        }
    }
}