using System;

namespace _557_Reverse_Words_in_a_String_III
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "Hello World!";
            var result = new Solution().ReverseWords(input);
            Console.WriteLine($"The reverse words of {input} is: {result}.");
        }
    }
}
