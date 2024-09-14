using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class MinimumBitFlips
    {
        public int Solution(int start, int goal)
        {
            var xorResult = start ^ goal;

            int count = 0;
            while (xorResult > 0)
            {
                count += xorResult & 1;
                xorResult >>= 1;
            }
            return count;
        }
    }
}
