using System;

namespace _1217_Minimum_Cost_to_Move_Chips_to_The_Same_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[5]{2,2,2,3,3};
            var res = new Solution().MinCostToMoveChips(arr);
            Console.WriteLine(res);
        }
    }
}
