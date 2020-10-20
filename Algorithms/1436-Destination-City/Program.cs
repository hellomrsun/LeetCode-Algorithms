using System;
using System.Collections.Generic;

namespace _1436_Destination_City
{
    class Program
    {
        static void Main(string[] args)
        {
            var routes = new List<IList<string>>{
                new List<string>{"Paris", "London"},
                new List<string>{"London", "New York"},
                new List<string>{"New York", "Tokyo"},
                new List<string>{"Tokyo", "Beijing"}
            };
            var result = new Solution().DestCity(routes);
            Console.WriteLine($"The destination city of {routes[0][0]} is: {result}!");
        }
    }
}
