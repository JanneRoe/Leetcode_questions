using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Utils
{
    public static class Utils
    {
        public static void PrintArray(Array array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array.GetValue(i).ToString());
                if(i != array.Length - 1)
                {
                    Console.Write(",");
                }                
            }
            Console.WriteLine("]");
        }

        public static int IntFactorial(int factor)
        {
            int factorResult = 1;
            for (int i = factor; i > 0; i--)
            {
                factorResult *= i;
            }
            return factorResult;
        }
    }
}
