using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Medium
{
    public class ContainerOperations
    {
        List<int> container;
        public ContainerOperations()
        {
            container = new List<int>();
        }

        public string[] Solution(string[][] queries)
        {

            string[] result = new string[queries.Length];
            int i = 0;
            foreach (string[] query in queries)
            {
                string operation = query[0];
                if (int.TryParse(query[1], out int value))
                {
                    if (operation == "ADD")
                    {
                        //add
                        container.Add(value);
                        result[i] = "_";
                    }
                    else if (operation == "EXISTS")
                    {
                        if (container.Contains(value))
                        {
                            result[i] = "true";
                        }
                        else
                        {
                            result[i] = "false";
                        }
                    }
                    else if (operation == "REMOVE")
                    {
                        if (container.Any(c => c == value))
                        {

                            var index = container.IndexOf(value);
                            container.RemoveAt(index);
                            result[i] = "true";
                        }
                        else
                        {
                            result[i] = "true";
                        }
                    }
                    else if (operation == "GET_NEXT")
                    {
                        container = container.OrderBy(c => c).ToList();
                        for (int j = 0; j < container.Count; j++)
                        {
                            if (container[j] < value)
                                continue;
                            else
                            {
                                if (container[j] > value)
                                {
                                    result[i] = container[j].ToString();
                                    break;
                                }
                            }
                            result[i] = "_";
                        }

                    }
                }
                i++;
            }

            return result;

        }
    }
}
