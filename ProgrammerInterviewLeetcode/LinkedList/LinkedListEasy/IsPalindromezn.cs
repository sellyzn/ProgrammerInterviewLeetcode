using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.LinkedList.LinkedListEasy
{
    public class IsPalindromezn
    {
        public bool isPalindrome(ListNode head)
        {
            var st = new Stack<int>();
            var p = head;
            while(p != null)
            {
                st.Push(p.val);
                p = p.next;
            }
            var q = head;
            while(q != null)
            {
                if(q.val != st.Peek())   //can not use Pop() here. will report stack empty error in below st.Pop() command line.
                {
                    return false;
                }
                else
                {
                    q = q.next;
                    st.Pop();
                }
            }
            return true;
        }

        //Program Main test case
        //var arr = new int[] { 1 };
        //var lli = new LinkList(arr); 
        //var res = isPalindrome(lli.head);
        //if (res == true)
        //    Console.WriteLine("true");
        //else
        //    Console.WriteLine("false");

        
    }
}
