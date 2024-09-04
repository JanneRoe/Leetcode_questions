using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class SumofDigitsofStringAfterConvert
    {
        public int GetLucky(string s, int k)
        {
            string word = s;
            int result = 0;
            List<int> numbers = new List<int>();
            foreach (var letter in word)
            {
                numbers.Add(GetLetterNumber(letter));
            }
            while (k > 0)
            {
                result = 0;
                foreach (var number in numbers)
                {
                    result += number;
                }
                word = result.ToString();
                numbers.Clear();
                foreach (var l in word)
                {
                    int n;
                    if (int.TryParse(l.ToString(), out n))
                        numbers.Add(n);
                }
                k--;
            }
            return result;
        }


        public int GetLetterNumber(char letter)
        {
            if (letter == 'a' || letter == 'A' ||
                letter == 'j' || letter == 'J' ||
                letter == 's' || letter == 'S') { return 1; }
            if (letter == 'b' || letter == 'B' ||
                letter == 'k' || letter == 'K' ||
                letter == 't' || letter == 'T') { return 2; }
            if (letter == 'c' || letter == 'C' ||
                letter == 'l' || letter == 'L' ||
                letter == 'u' || letter == 'U') { return 3; }
            if (letter == 'd' || letter == 'D' ||
                letter == 'm' || letter == 'M' ||
                letter == 'v' || letter == 'V') { return 4; }
            if (letter == 'e' || letter == 'E' ||
                letter == 'n' || letter == 'N' ||
                letter == 'w' || letter == 'W') { return 5; }
            if (letter == 'f' || letter == 'F' ||
                letter == 'o' || letter == 'O' ||
                letter == 'x' || letter == 'X') { return 6; }
            if (letter == 'g' || letter == 'G' ||
                letter == 'p' || letter == 'P' ||
                letter == 'y' || letter == 'Y') { return 7; }
            if (letter == 'h' || letter == 'H' ||
                letter == 'q' || letter == 'Q' ||
                letter == 'z' || letter == 'Z') { return 8; }
            if (letter == 'i' || letter == 'I' ||
                letter == 'r' || letter == 'R') { return 9; }

            else { return 0; }
        }

        public int GetIntLetter(string s)
        {
            int sum = 0;
            foreach (char c in s)
            {
                int value = c - 'a' + 1;
                sum += SumOfDigits(value);
            }
            return sum;
        }

        private int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }

    //public class Solution
    //{
    //    public int GetLucky(string s, int k)
    //    {
    //        // Step 1: Convert each character in the string to its position in the alphabet
    //        int sum = 0;
    //        foreach (char c in s)
    //        {
    //            int value = c - 'a' + 1;
    //            sum += SumOfDigits(value);
    //        }

    //        // Step 2: Perform the transformation k times
    //        for (int i = 1; i < k; i++)
    //        {
    //            sum = SumOfDigits(sum);
    //        }

    //        return sum;
    //    }

    //    private int SumOfDigits(int num)
    //    {
    //        int sum = 0;
    //        while (num > 0)
    //        {
    //            sum += num % 10;
    //            num /= 10;
    //        }
    //        return sum;
    //    }
    //}

}
