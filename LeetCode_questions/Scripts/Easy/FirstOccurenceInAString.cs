using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class FirstOccurenceInAString
    {
        /*Given two strings needle and haystack, 
         * return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.*/

        public int Solution(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
