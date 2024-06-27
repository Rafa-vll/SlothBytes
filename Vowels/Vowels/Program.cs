namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            int vowelCount = CountVowels(word);

            Console.WriteLine($"Number of vowels in '{word}': {vowelCount}");
        }

        static int CountVowels(string str)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
