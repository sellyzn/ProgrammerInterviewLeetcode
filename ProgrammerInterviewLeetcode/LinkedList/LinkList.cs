using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.LinkedList
{
    public class LinkList
    {
        public ListNode head;
        public LinkList()
        {
            head = null;
        }
        public LinkList(int[] arr)
        {
            if (arr == null || arr.Length <= 0)
                return;
            head = new ListNode(arr[0]);
            ListNode temp = head;
            for (int i = 1; i < arr.Length; i++)
            {
                temp.next = new ListNode(arr[i]);
                temp = temp.next;
            }

        }
    }
}
