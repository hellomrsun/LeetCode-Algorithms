using System;

namespace _394_Decode_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "3[a]2[bc]";
            var res1 = new Solution().DecodeString(s1);
            Console.WriteLine(res1);

            var s2 = "3[a2[c]]";
            var res2 = new Solution().DecodeString(s2);
            Console.WriteLine(res2);

            var s3 = "2[abc]3[cd]ef";
            var res3 = new Solution().DecodeString(s3);
            Console.WriteLine(res3);

            var s4 = "abc3[cd]xyz";
            var res4 = new Solution().DecodeString(s4);
            Console.WriteLine(res4);
        }
    }
}
