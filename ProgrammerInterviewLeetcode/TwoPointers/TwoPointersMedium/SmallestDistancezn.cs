using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.TwoPointers.TwoPointersMedium
{
    public class SmallestDistancezn
    {
        //public int SmallestDifference(int[] a, int[] b)
        //{
        //    var minDistance = int.MaxValue;
        //    var i = 0;
        //    var j = 0;
        //    while (i < a.Length && j < b.Length)
        //    {
        //        while(a[i] < b[j])
        //        {
        //            minDistance = Math.Min(minDistance, b[j] - a[i]);
        //            i++;
        //        }
        //        while(a[i] >= b[j])
        //        {
        //            minDistance = Math.Min(minDistance, a[i] - b[j]);
        //            j++;
        //        }
        //    }
        //    return minDistance;
        //}

        public int SmallestDifference(int[] a, int[] b)
        {
            a = insertSort(a);
            b = insertSort(b);
            var minDifference = long.MaxValue;
            var i = 0;
            var j = 0;
            while (i < a.Length && j < b.Length)
            {
                minDifference = Math.Min(minDifference, Math.Abs((long)a[i] - (long)b[j]));
                if (a[i] < b[j])
                    i++;
                else
                    j++;
            }
            return (int)minDifference;
        }
        public int[] insertSort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return null;
            for (var i = 1; i < arr.Length; i++)
            {
                var tmp = arr[i];
                int j;
                for (j = i; j > 0 && arr[j - 1] > tmp; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[j] = tmp;
            }
            return arr;
        }

        //Main:
        ////var arr1 = new int[] { 1, 3, 15, 11, 2 };
        ////var arr2 = new int[] { 23, 127, 235, 19, 8 };
        //var arr1 = new int[] { -2147483648};
        //var arr2 = new int[] { 2147483647};
        //var res = SmallestDifference(arr1, arr2);
        //Console.WriteLine(res);
    }
}
