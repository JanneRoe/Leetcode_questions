using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class RomanToInteger
    {
        private readonly Dictionary<char, int> _list = new Dictionary<char, int>
        {
            {'i', 1} ,{'v', 5}, {'x', 10}, {'l', 50}, {'c',100},{'d',500},{'m',1000}
        };
        public int Solution(string s) 
        {
            s = s.ToLower();
            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int current = _list[s[i]];
                int next = (i < s.Length - 1) ? _list[s[i + 1]] : 0;

                // Si el valor actual es menor que el siguiente, restamos; de lo contrario, sumamos.
                number += current < next ? -current : current;
            }

            return number;
        }
    }
}
