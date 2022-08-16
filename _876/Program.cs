using System;

namespace _876
{
    class Program
    {
        public static void Main(String[] args)
        {
            Solution solution = new Solution();
        }
    }

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
     }
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            List<int> list = new List<int>();
            ListNode headCopy = head;

            while (head.next != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            if (list.Count % 2 == 0)
            {
                for (int i = 0; i < list.Count / 2; i++)
                {
                    headCopy = headCopy.next;
                }
            }
            else
            {
                for (int i = 0; i <= list.Count / 2; i++)
                {
                    headCopy = headCopy.next;
                }
            }
            return headCopy;
        }
    }
}
