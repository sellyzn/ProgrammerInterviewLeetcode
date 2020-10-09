using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.LinkedList.LinkedListEasy
{
    public class RemoveDuplicateNodeszn
    {
        public ListNode RemoveDuplicateNodes(ListNode head)
        {
            if (head == null)
                return head;
            var set = new HashSet<int>();
            set.Add(head.val);  //must add head value first.
            var pre = head;
            var cur = head;
            while (cur != null)
            {
                if (set.Contains(cur.val))
                {
                    pre.next = cur.next;
                    cur = cur.next;
                }
                else
                {
                    set.Add(cur.val);
                    pre = pre.next;
                    cur = cur.next;
                }
            }
            return head;
        }
    }
}
