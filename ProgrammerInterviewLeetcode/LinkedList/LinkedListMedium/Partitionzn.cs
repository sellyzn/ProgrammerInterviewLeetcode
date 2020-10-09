using ProgrammerInterviewLeetcode.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.LinkedList.LinkedListMedium
{
    public class Partitionzn
    {
        public ListNode Partition(ListNode head, int x)
        {
            var left = new ListNode(0);
            var right = new ListNode(0);
            left.next = null;
            right.next = null;
            var l = left;
            var r = right;
            var cur = head;
            while (cur != null)
            {
                if (cur.val < x)
                {
                    left.next = cur;
                    left = left.next;
                }
                else
                {
                    right.next = cur;
                    right = right.next;
                }
                cur = cur.next;
            }
            right.next = null;
            left.next = r.next;
            return l.next;
        }

        //two pointers
        public ListNode Partition1(ListNode head, int x)
        {
            var p = head;
            var q = head;
            if (head == null || head.next == null)
                return head;
            while (p != null)
            {
                if (p.val < x)
                {
                    var temp = p.val;
                    p.val = q.val;
                    q.val = temp;
                    q = q.next;
                }
                p = p.next;
            }
            return head;
        }
    }
}
