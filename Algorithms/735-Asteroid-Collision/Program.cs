using System;

namespace _735_Asteroid_Collision
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3]{5,10,-5};
            var result = new Solution().AsteroidCollision(arr);
            Console.WriteLine($"The result of input {string.Join(",", arr)} is: {string.Join(",", result)}");

            var arr2 = new int[2]{8, -8};
            var result2 = new Solution().AsteroidCollision(arr2);
            Console.WriteLine($"The result2 of input {string.Join(",", arr2)} is: {string.Join(",", result2)}");

            var arr3 = new int[3]{10,2,-5};
            var result3 = new Solution().AsteroidCollision(arr3);
            Console.WriteLine($"The result3 of input {string.Join(",", arr3)} is: {string.Join(",", result3)}");

            var arr4 = new int[4]{-2,-1,1,2};
            var result4 = new Solution().AsteroidCollision(arr4);
            Console.WriteLine($"The result4 of input {string.Join(",", arr4)} is: {string.Join(",", result4)}");
        }
    }
}
