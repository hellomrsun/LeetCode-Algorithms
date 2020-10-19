using System;

namespace _188_Best_Time_to_Buy_and_Sell_Stock_IV
{
    class Program
    {
        static void Main(string[] args)
        {
           var result = new Solution().MaxProfit(2, new int[]{3,2,6,5,0,3});
           Console.WriteLine("the maximum profit is:" + result);
        }
    }
}
