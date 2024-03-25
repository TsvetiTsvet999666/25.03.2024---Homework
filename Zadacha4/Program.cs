using Microsoft.VisualBasic;

namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToCensor = Console.ReadLine();
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?', '*' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(wordToCensor, StringComparison.OrdinalIgnoreCase))
                {
                    words[i] = new string('*', words[i].Length);
                }
            }
            string censoredSentence = string.Join(" ", words);
            Console.WriteLine(censoredSentence);
        }
    }
}
