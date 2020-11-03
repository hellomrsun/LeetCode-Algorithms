using System;
using System.Text;
using System.Collections.Generic;

namespace _147_Insertion_Sort_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new ListNode(4, new ListNode(2, new ListNode(1, new ListNode(3))));
            var res = new Solution().InsertionSortList(node);
            var list = new List<int>();
            while(res != null){
                list.Add(res.val);
                res = res.next;
            }
            Console.WriteLine(string.Join("->", list));
        }
    }
}
