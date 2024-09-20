using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class LenghtOfLastWord
    {
        /*Given a string s consisting of words and spaces, return the length of the last word in the string.

            A word is a maximal 
            substring
             consisting of non-space characters only.*/
        public int Solution(string s)
        {
            var words = s.Split(' ');
            return words.Where(s => s != "").ToArray().LastOrDefault().Length;
        }
    }
}
