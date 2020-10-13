using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerInterviewLeetcode.TwoPointers.TwoPointersMedium
{
    public class WordsDistancezn
    {
        public int FindClosest(string[] words, string word1, string word2)
        {
            var firstIndex = -1;
            var secondIndex = -1;
            var minCloset = word1.Length - 1;
            for(var i = 0; i < words.Length; i++)
            {
                if (words[i] == word1)
                    firstIndex = i;
                if (words[i] == word2)
                    secondIndex = i;
                if (firstIndex != -1 && secondIndex != -1)
                    minCloset = Math.Min(minCloset, Math.Abs(firstIndex - secondIndex));
            }
            return minCloset;
        }
    }
}
