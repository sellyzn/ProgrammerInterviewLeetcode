using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.TwoPointers.TwoPointersMedium
{
    public class SearchMartrixzn
    {
        

        public static bool SearchMatrixMine(int[][] matrix, int target)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] > target)
                        break;
                    if (matrix[i][j] == target)
                        return true;
                }
                if (matrix[i][0] > target)
                    break;
            }
            return false;
        }

        //report error: Unhandled Exception: System.IndexOutOfRangeException: Index was outside the bounds of the array.
        public static bool SearchMatrixBug(int[][] matrix, int target)
        {
            var x = matrix.Length - 1;
            var y = 0;
            while (x >= 0 && y <= matrix[0].Length - 1)
            {
                if (matrix[x][y] < target)
                {
                    y++;
                }
                if (matrix[x][y] > target)
                {
                    x--;
                }
                if (matrix[x][y] == target)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool SearchMatrixDebug(int[][] matrix, int target)
        {
            var x = matrix.Length - 1;
            var y = 0;
            while (x >= 0 && y <= matrix[0].Length - 1)
            {
                if (matrix[x][y] < target)
                {
                    y++;
                }
                else if (matrix[x][y] > target)
                {
                    x--;
                }
                else if (matrix[x][y] == target)
                {
                    return true;
                }
            }
            return false;
        }

        //Main:
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
    }
}
