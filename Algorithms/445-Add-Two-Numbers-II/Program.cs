using System;
using System.Text;
using System.Collections.Generic;

namespace _445_Add_Two_Numbers_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new ListNode(7, new ListNode(2, new ListNode(4, new ListNode(3))));
            var node2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var result = new Solution().AddTwoNumbers(node1, node2);

            var l = new List<int>();
            while(result != null){
                l.Add(result.val);
                result = result.next;
            }
            
            Console.WriteLine(string.Join('>', l));
        }
    }
}
