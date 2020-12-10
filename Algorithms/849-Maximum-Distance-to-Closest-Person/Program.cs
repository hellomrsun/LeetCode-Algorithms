using System;

namespace _849_Maximum_Distance_to_Closest_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[7]{1,0,0,0,1,0,1};
            var res = new Solution().MaxDistToClosest(arr);
            Console.WriteLine(res);
        }
    }
}
