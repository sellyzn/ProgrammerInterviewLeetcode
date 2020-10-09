using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.LinkedList.LinkedListEasy
{
    public class GetIntersectionNodezn
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
                return null;
            var curA = headA;
            var curB = headB;
            var lenA = 0;
            var lenB = 0;
            while(curA != null)
            {
                lenA++;
                curA = curA.next;
            }
            while(curB != null)
            {
                lenB++;
                curB = curB.next;
            }
            curA = headA;
            curB = headB;
            //if(lenB > lenA)
            //{
            //    swap(lenA, lenB);
            //    swap(curA, curB);
            //}
            //var diff = lenA - lenB;
            //while(diff > 0)
            //{
            //    curA = curA.next;
            //    diff--;
            //}
            var diff = lenA - lenB;
            if(diff >= 0)
            {
                while(diff > 0)
                {
                    curA = curA.next;
                    diff--;
                }
            }
            else
            {
                while(diff < 0)
                {
                    curB = curB.next;
                    diff++;
                }
            }
            while(curA != null)
            {
                if(curA == curB)
                {
                    return curA;
                }
                curA = curA.next;
                curB = curB.next;
            }
            return null;
        }

        private void swap(ListNode curA, ListNode curB)
        {
            var temp = curA;
            curA = curB;
            curB = temp;
        }

        public void swap(int lenA, int lenB)
        {
            var temp = lenA;
            lenA = lenB;
            lenB = temp;
        }
    }
}
