namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word2 = Console.ReadLine();
            string word = word2.ToLower();
            

            int vowelCount = CountVowels(word);

            Console.WriteLine($"Number of vowels in '{word2}': {vowelCount}");
        }

        static int CountVowels(string str)
        {
            int count = 0;
            string vowels = "aeiou";

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
