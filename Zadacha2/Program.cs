using System.Text.RegularExpressions;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\d+)([A-Za-z])";
            string text = Console.ReadLine();
            foreach (Match match in Regex.Matches(text, pattern))
            {
                text = Regex.Replace(text, match.Groups[1].Value, match.Groups[2].Value);
            }
            Console.WriteLine(text);
        }
    }
}
