using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class PalindromeNumber
    {
        public bool IsNumberPalindrome(int number)
        {
           if(number <= 10) return false;
           return number == VoltearNumero(number);
        }

        private int VoltearNumero(int number) 
        {
            var nString = number.ToString();
            string inversedString = "";
            for (var i = (nString.Length - 1); i >= 0; i--) 
            { 
                char t = nString[i];
                inversedString += t;
            }

            if (int.TryParse(inversedString, out var num)) 
            {
                return num;
            }
            else { return 0; }
        }


        public bool IsPalindrome(int x)
        {
            // Negative numbers and numbers ending with 0 (except 0 itself) are not palindromes
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int reversed = 0;
            int original = x;

            // Reverse the integer
            while (x > 0)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }

            // Check if the original number is equal to the reversed number
            return original == reversed;
        }
    }
}
