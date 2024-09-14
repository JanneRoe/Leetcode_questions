using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class LongestCommonPrefix
    {
        /*Write a function to find the longest common prefix string amongst an array of strings.

        If there is no common prefix, return an empty string "".*/

        public string Solution(string[] strs)
        {
            if(strs == null || strs.Length == 0)
            {
                return string.Empty;
            }

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                var s = strs[i];
                var j = s.IndexOf(prefix);

                //El método string.IndexOf en C# busca la primera aparición de una subcadena o carácter dentro
                //de una cadena y devuelve la posición (índice) de la primera aparición.
                //Si la subcadena o carácter no se encuentra, el método devuelve -1.
                while (strs[i].IndexOf(prefix) != 0)
                {
                    s = strs[i];
                    j = s.IndexOf(prefix);
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == string.Empty)
                        return string.Empty;
                }
            }

            return prefix;
        }        
    }
}
