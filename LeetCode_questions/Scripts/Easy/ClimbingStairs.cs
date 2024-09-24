using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static LeetCode_questions.Utils.Utils;

namespace LeetCode_questions.Scripts.Easy
{
    public class ClimbingStairs
    {
        /*You are climbing a staircase. It takes n steps to reach the top.

        Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?*/

        public BigInteger Solution(int n)
        {
            if(n == 0) return 0;
            if(n == 1) return 1;

            int div = n / 2;

            BigInteger waysToClimb = 1;
            
            for (int i = div; i > 0; i--)
            {
                waysToClimb += BigIntFactorial(n - i) / (BigIntFactorial(i) * BigIntFactorial(n - 2 * i));
            }

            return waysToClimb;
        }
    }
}
