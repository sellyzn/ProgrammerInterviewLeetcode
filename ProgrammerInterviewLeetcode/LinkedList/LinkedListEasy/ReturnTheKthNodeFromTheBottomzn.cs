using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.LinkedList.LinkedListEasy
{
    public class ReturnTheKthNodeFromTheBottomzn
    {
        public int kthToLast(ListNode head, int k)
        {
            var fast = head;
            var slow = head;
            for(var i = 0; i < k; i++)
            {
                fast = fast.next;
            }
            while(fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            return slow.val;
        }
    }
}
