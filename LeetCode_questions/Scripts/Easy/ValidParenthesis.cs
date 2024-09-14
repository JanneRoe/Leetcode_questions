namespace LeetCode_questions.Scripts.Easy
{
    public class ValidParenthesis
    {
        /*Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        An input string is valid if:

        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Every close bracket has a corresponding open bracket of the same type.*/

        //Hints
        //Use a stack of characters.
        //When you encounter an opening bracket, push it to the top of the stack.
        //When you encounter a closing bracket, check if the top of the stack was the opening for it. If yes, pop it from the stack. Otherwise, return false.


        private readonly Dictionary<char,char> brackets = new Dictionary<char, char>
        {
            {'{','}' }, {'(', ')' }, {'[' , ']' }
        };
        public bool Solution(string s)
        {
            if(string.IsNullOrEmpty(s)) return false;


            Stack<char> bracketStack = new Stack<char>();
            foreach(char c in s)
            {
                if (brackets.ContainsKey(c)) //is an opening bracket
                {
                    bracketStack.Push(c);
                }
                else //is a closing bracket
                {
                    var b = bracketStack.Pop();
                    if (brackets[b] != c)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}