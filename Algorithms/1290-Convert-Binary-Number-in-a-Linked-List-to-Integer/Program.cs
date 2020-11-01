using System;

namespace _1290_Convert_Binary_Number_in_a_Linked_List_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new ListNode(1, new ListNode(0, new ListNode(1, new ListNode(1))));
            var res = new Solution().GetDecimalValue(node);
            Console.WriteLine("Result is:" + res);
        }
    }
}
