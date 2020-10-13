using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.BinarySearch.BinarySearchEasy
{
    public class MagicIndexzn
    {
        public int findMagicIndex(int[] nums)
        {
            var index = -1;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == i)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public int findMagicIndexSymply(int[] nums)
        {            
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == i)
                    return i;
            }
            return -1;
        }

        public int findMagicIndexUp(int[] nums)
        {
            
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == i)
                    return i;
                if (nums[i] > i)
                    i = nums[i] - 1;
            }
            return -1;
        }
    }
}
