using System;

namespace _142_Linked_List_Cycle_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new ListNode(3);
            node.next = new ListNode(2);
            node.next.next = new ListNode(0);
            node.next.next.next = new ListNode(-4);
            node.next.next.next.next = node;
            var res = new Solution().DetectCycle(node);
            Console.WriteLine(res.val);
        }
    }
}
