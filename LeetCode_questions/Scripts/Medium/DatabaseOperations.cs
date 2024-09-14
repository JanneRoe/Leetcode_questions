using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Medium
{
    public class DatabaseOperations
    {
        Dictionary<string, Dictionary<string, string>> database = new Dictionary<string, Dictionary<string, string>>();
        //SET  GET   DELETE <key><field><value>
        public string[] Solution(string[][] queries)
        {
            string[] result = new string[queries.Length];
            int resultIndex = 0;
            foreach (string[] query in queries)
            {
                var operation = query[0];
                switch(operation)
                {
                    case "SET":
                        var key = query[1];
                        var field = query[2];
                        var value = query[3];

                        if (database.ContainsKey(key))
                        {
                            //update
                            var keyDictionary = database[key];
                            if (!keyDictionary.ContainsKey(field))
                            {
                                keyDictionary.Add(field, value);
                            }
                            else
                            {
                                keyDictionary[field] = value;
                            }                            
                        }
                        else
                        {
                            //create
                            database.Add(key, new Dictionary<string, string> { {field ,value } });
                        }
                        result[resultIndex] = "";

                        break;
                    case "GET":
                        key = query[1];
                        field = query[2];

                        if (database.ContainsKey(key))
                        {
                            var keyDictionary = database[key];
                            if (keyDictionary.ContainsKey(field))
                            {
                                result[resultIndex] = keyDictionary[field];
                            }
                            else
                            {
                                result[resultIndex] = "";
                            }
                        }
                        else
                        {
                            result[resultIndex] = "";
                        }

                        break;
                    case "DELETE":
                        key = query[1];
                        field = query[2];
                        if (database.ContainsKey(key))
                        {
                            var keyDictionary = database[key];
                            if (keyDictionary.ContainsKey(field))
                            {
                                keyDictionary.Remove(field);
                                
                                result[resultIndex] = "true";
                            }
                            else
                            {
                                result[resultIndex] = "false";
                            }
                        }
                        else
                        {
                            result[resultIndex] = "false";
                        }
                        break;
                    default:
                        break;
                }

                resultIndex++;
            }

            return result;
        }
    }
        
}
