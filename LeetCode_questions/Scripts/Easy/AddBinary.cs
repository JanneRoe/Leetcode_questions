namespace LeetCode_questions.Scripts.Easy
{
    public class AddBinary
    {
        public string Solution(string a, string b)
        {
            int sum = Convert.ToInt32(a,2) + Convert.ToInt32(b,2);

            return Convert.ToString(sum,2);
        }
    }
}
