using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.TwoPointers.TwoPointersEasy
{
    public class MergeTwoSortedArrayszn
    {
        //A = [1,2,3,0,0,0]   m = 3
        //B = [2,5,6]         n = 3
        //Output: [1,2,2,3,5,6]
        public void Merge(int[] A, int m, int[] B, int n)
        {
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
        }

        public void MergeS(int[] A, int m, int[] B, int n)
        {
            var i = m + n - 1;
            while (m > 0 && n > 0)
            {
                A[i--] = (A[m - 1] > B[n - 1]) ? A[(m--) - 1] : B[(n--) - 1];
            }
            while (m > 0)
            {
                A[i--] = A[(m--) - 1];
            }
            while (n > 0)
            {
                A[i--] = B[(n--) - 1];
            }
        }

        public void MergeUp(int[] A, int m, int[] B, int n)
        {
            var i = m - 1;
            var j = n - 1;
            var k = m + n - 1;
            while(i >= 0 && j >= 0)
            {
                if (A[i] < B[j])
                    A[k--] = B[j--];
                else
                    A[k--] = A[i--];
            }
            while (j >= 0)
                A[k--] = B[j--];
        }
    }
}
