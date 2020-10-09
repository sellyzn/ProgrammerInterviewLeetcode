using ProgrammerInterviewLeetcode.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.LinkedList.LinkedListMedium
{
    public class DetectCyclezn
    {
        public static ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return null;
            var fast = head;
            var slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (slow == fast)
                    break;
            }
            if (fast == null || fast.next == null)
                return null;
            slow = head;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return slow;
        }
    }
}
