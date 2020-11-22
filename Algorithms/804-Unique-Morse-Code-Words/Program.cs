using System;

namespace _804_Unique_Morse_Code_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[4] {"gin", "zen", "gig", "msg"};
            var res = new Solution().UniqueMorseRepresentations(words);
            Console.WriteLine(res); //2
        }
    }
}
