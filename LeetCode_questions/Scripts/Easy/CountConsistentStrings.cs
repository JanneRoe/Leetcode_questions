using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class CountConsistentStrings
    {
        /*You are given a string allowed consisting of distinct characters and an array of strings words. A string is consistent if all characters in the string appear in the string allowed.
        Return the number of consistent strings in the array words.*/
        //A string is incorrect if it contains a character that is not allowed
        //Constraints are small enough for brute force
        public int Solution(string allowed, string[] words)
        {
            if (string.IsNullOrEmpty(allowed) || words == null || words.Length == 0)
                return 0;

            var allowedSet = new HashSet<char>(allowed); //Esto mejora la búsqueda de caracteres permitidos, ya que HashSet tiene una búsqueda en tiempo constante.
            int allowedWords = 0;

            foreach (var word in words)
            {
                if (word.All(c => allowedSet.Contains(c))) //Esta función evalúa si todos los caracteres de la palabra están en el conjunto de caracteres permitidos (allowedSet), eliminando la necesidad de contar coincidencias manualmente.
                {
                    allowedWords++;
                }
            }

            return allowedWords;
        }


        private int CountCoincidences(char s, string word)
        {
            int counter = 0;    
            foreach (char c in word)
            {
                if (s == c) counter++;
            }


            return counter;
        }
    }
}
