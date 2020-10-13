using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.LinkedList.LinkedListMedium
{
    public class AddTwoNumberszn
    {
        public ListNode AddTwoNumbersWrong(ListNode l1, ListNode l2)
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


        public static ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            ListNode res = new ListNode(0);
            var r = res;
            var carry = 0;
            while (l1 != null && l2 != null)
            {
                if (l1.val + l2.val + carry > 9)
                {
                    res.next = new ListNode(l1.val + l2.val + carry - 10);
                    carry = 1;
                }
                else
                {
                    res.next = new ListNode(l1.val + l2.val + carry);
                    carry = 0;
                }
                l1 = l1.next;
                l2 = l2.next;
                res = res.next;
            }
            while (l1 != null)
            {
                if (l1.val + carry > 9)
                {
                    res.next = new ListNode(l1.val + carry - 10);
                    carry = 1;
                }
                else
                {
                    res.next = new ListNode(l1.val + carry);
                    carry = 0;
                }
                l1 = l1.next;
                res = res.next;
            }
            while (l2 != null)
            {
                if (l2.val + carry > 9)
                {
                    res.next = new ListNode(l2.val + carry - 10);
                    carry = 1;
                }
                else
                {
                    res.next = new ListNode(l2.val + carry);
                    carry = 0;
                }
                l2 = l2.next;
                res = res.next;
            }
            if (carry == 1)
            {
                res.next = new ListNode(1);
                res = res.next;
            }
            return r.next;
        }

        //Program Main test case:
        //var arrA = new int[] { 2, 4, 3, 1 };
        //var arrB = new int[] { 5, 6, 1 };
        //var liA = new LinkList(arrA);
        //var liB = new LinkList(arrB);
        //var lnA = liA.head;
        //var lnB = liB.head;
        //var arrC = addTwoNumbers(lnA, lnB);

        //while (arrC != null)
        //{
        //    Console.WriteLine(arrC.val);
        //    arrC = arrC.next;
        //}
    }
}
