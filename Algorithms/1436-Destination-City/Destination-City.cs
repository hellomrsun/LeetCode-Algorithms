using System;
using System.Collections;
using System.Collections.Generic;

namespace _1436_Destination_City
{
    public class Solution
    {
        public string DestCity(IList<IList<string>> paths)
        {
            var dict = new Dictionary<string, string>();

            // Initialize a dictionary with source and destination city pair
            foreach (var path in paths)
            {
                dict.Add(path[0], path[1]);
            }

            var sourceCity = paths[0][1];
            while (dict.ContainsKey(sourceCity))
            {
                // Set the destination city as source for the next search
                sourceCity = dict[sourceCity];
            }
            
            return sourceCity;
        }
    }
}