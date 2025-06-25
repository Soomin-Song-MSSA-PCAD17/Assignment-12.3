using System.Text;

namespace LeetCode1047
{
    public class Solution
    {
        public string RemoveDuplicates(string s)
        {
            if (s.Length < 2) { return s; }

            StringBuilder sb = new();
            foreach (char c in s)
            {
                if (sb.Length > 0 && sb[sb.Length - 1] == c)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
