using ReVerseMVC.Models;

namespace ReVerseMVC.Logic
{
    public class StringReverse
    {
        public static string GetString(ReVerse reVerse)
        {
            string output = "";

            string revString = ReverseString(reVerse.StartString);

            return output = DisplayString(revString);
        }

        public static string ReverseString(string input)
        {
            string output = "";

            char[] chars = input.ToCharArray();

            for (int i = chars.Length - 1; i > -1; i--)
            {
                output += chars[i];
            }

            return output;
        }

        public static string DisplayString(string revString)
        {
            return revString;
        }
    }
}
