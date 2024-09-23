using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class MySqrt
    {
        /*Given a non-negative integer x, return the square root of x rounded down to the nearest integer. 
         * The returned integer should be non-negative as well.

         * You must not use any built-in exponent function or operator.

         * For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.*/
        public int Solution(int n) 
        {
            if(n<0) return 0;

            int i = 1;
            while (i * i <= n) 
            {
                i++;
            }
            return i-1;
        }
    }
}
