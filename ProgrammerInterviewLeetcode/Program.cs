using ProgrammerInterviewLeetcode.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var A = new int[] { 1, 2, 3, 0, 0, 0 };
            var B = new int[] { 2, 5, 6 };
            Merge(A, 3, B, 3);
            foreach(var num in A)
            {
                Console.WriteLine(num);
            }
        }
        public static void Merge(int[] A, int m, int[] B, int n)
        {
            //for (var i = m + n - 1; i >= 0; i--)
            //{
            var i = m + n - 1;
            while (m > 0 && n > 0)
            {
                //if(A[m - 1] > B[n - 1])
                //{
                //    A[i] = A[m - 1];
                //    i--;
                //    m--;
                //}
                //else
                //{
                //    A[i] = B[n - 1];
                //    i--;
                //    n--;
                //}
                A[i--] = (A[m - 1] > B[n - 1]) ? A[(m--) - 1] : B[(n--) - 1];
               
            }
            while (m > 0)
            {
                A[i--] = A[(m--) - 1];
                //m--;
                //i--;
            }
            while (n > 0)
            {
                A[i--] = B[(n--) - 1];
                //n--;
                //i--;
            }

            //}
        }
        public static bool isPalindrome(ListNode head)
        {
            var st = new Stack<int>();
            var p = head;
            while (p != null)
            {
                st.Push(p.val);
                p = p.next;
            }
            var q = head;
            while (q != null)
            {
                if (q.val != st.Pop())
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

    }
}
