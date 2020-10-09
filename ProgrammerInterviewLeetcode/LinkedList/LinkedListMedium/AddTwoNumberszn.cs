using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.LinkedList.LinkedListMedium
{
    public class AddTwoNumberszn
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            var res = new ListNode(0);
            res.next = null;
            var r = res;
            var carry = 0;
            
            while(l1 != null && l2 != null)
            {
                if(l1.val + l2.val > 9)
                {
                    res.val = l1.val + l2.val + carry - 10;
                    carry = 1;
                }
                else
                {
                    res.val = l1.val + l2.val + carry;
                }
                l1 = l1.next;
                l2 = l2.next;
                res.next = new ListNode(res.val);
                res = res.next;
                //res.next = null;
            }
            while(l1 != null)
            {
                res.val = l1.val + carry;
                l1 = l1.next;
                res.next = new ListNode(res.val);
                res = res.next;
                //res.next = null;
            }
            while(l2 != null)
            {
                res.val = l2.val + carry;
                l2 = l2.next;
                res.next = new ListNode(res.val);
                res = res.next;
                //res.next = null;
            }
            if(carry == 1)
            {
                res.next = new ListNode(1);
                res = res.next;
            }
            res.next = null;
            return r.next;
        }
    }
}
