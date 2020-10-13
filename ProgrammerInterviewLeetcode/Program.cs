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






            ////var arr1 = new int[] { 1, 3, 15, 11, 2 };
            ////var arr2 = new int[] { 23, 127, 235, 19, 8 };
            //var arr1 = new int[] { -2147483648};
            //var arr2 = new int[] { 2147483647};
            //var res = SmallestDifference(arr1, arr2);
            //Console.WriteLine(res);


            //var words = new string[] {"I", "am", "a", "student", "from", "a", "university", "in", "a", "city" };
            //var word1 = "a";
            //var word2 = "student";
            //var res = FindClosest(words, word1, word2);
            //Console.WriteLine(res);



            //var matrix = new int[][] { new int[]{ 1, 4, 7, 11, 15 },
            //                           new int[]{ 2, 5, 8, 12, 19 },
            //                           new int[]{ 3, 6, 9, 16, 22 },
            //                           new int[]{ 10, 15, 14, 17, 24 },
            //                           new int[]{ 18, 21, 23, 26, 30} };
            //var res = SearchMatrix(matrix, 31);
            //if (res == true)
            //    Console.WriteLine("true");
            //else
            //    Console.WriteLine("false");

            //var str = new string[] { "at", "", "", "", "ball", "", "", "car", "", "", "dad", "", "" };
            //var strt = "ball";
            //var res1 = FindString(str, strt);
            //Console.WriteLine(res1);

        }



        //public static int SmallestDifference(int[] a, int[] b)
        //{
        //    a = insertSort(a);
        //    b = insertSort(b);
        //    var minDistance = int.MaxValue;
        //    var i = 0;
        //    var j = 0;
        //    while (i < a.Length && j < b.Length)
        //    {
        //        while (i < a.Length && a[i] < b[j])
        //        {
        //            minDistance = Math.Min(minDistance, b[j] - a[i]);
        //            i++;
        //        }
        //        while (j < b.Length && a[i] >= b[j])
        //        {
        //            minDistance = Math.Min(minDistance, a[i] - b[j]);
        //            j++;
        //        }
        //    }
        //    return minDistance;
        //}


        //public static int SmallestDifference(int[] a, int[] b)
        //{
        //    a = insertSort(a);
        //    b = insertSort(b);
        //    var minDistance = long.MaxValue;
        //    //var i = 0;
        //    //var j = 0;
        //    //while (i < a.Length && j < b.Length)
        //    //{
        //    //    while (i < a.Length && a[i] < b[j])
        //    //    {
        //    //        minDistance = Math.Min(minDistance, b[j] - a[i]);
        //    //        i++;
        //    //    }
        //    //    while (j < b.Length && a[i] >= b[j])
        //    //    {
        //    //        minDistance = Math.Min(minDistance, a[i] - b[j]);
        //    //        j++;
        //    //    }
        //    //}


        //    //for (int i = 0, j = 0; i < a.Length && j < b.Length;)
        //    //{
        //    //    minDistance = Math.Min(minDistance, Math.Abs(a[i] - b[j]));
        //    //    if (a[i] < b[j])
        //    //    {
        //    //        i++;
        //    //    }
        //    //    else
        //    //    {
        //    //        j++;
        //    //    }
        //    //}
        //    var i = 0;
        //    var j = 0;
        //    while (i < a.Length && j < b.Length)
        //    {
        //        minDistance = Math.Min(minDistance, Math.Abs((long)a[i] - (long)b[j]));
        //        if (a[i] < b[j])
        //        {
        //            i++;
        //        }
        //        else
        //        {
        //            j++;
        //        }
        //    }

        //    return minDistance;

        //}


        public static int[] insertSort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return null;
            for(var i = 1; i < arr.Length; i++)
            {
                var tmp = arr[i];
                int j;
                for(j = i; j > 0 && arr[j - 1] > tmp; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[j] = tmp;
            }
            return arr;
        }

        
        //public static int FindString(string[] words, string s)
        //{
        //    var left = 0;
        //    var right = words.Length - 1;
        //    while(left <= right)
        //    {
        //        var mid = left + (right - left) / 2;
        //        var temp = mid;
        //        while(mid <= right && words[mid].Equals(""))
        //        {
        //            mid++;
        //        }
        //        if(mid == right + 1)
        //        {
        //            right = temp - 1;
        //            continue;
        //        }
        //        if (words[mid].Equals(s))
        //        {
        //            return mid;
        //        }else if(words[mid].CompareTo(s) > 0)
        //        {
        //            right = mid - 1;
        //        }else if(words[mid].CompareTo(s) < 0)
        //        {
        //            left = mid + 1;
        //        }
        //    }
        //    return -1;
        //}
















    }
}
