using System.Text;

namespace Change_letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string result = MoveLetters(word);

            Console.WriteLine($"Result after moving letters: {result}");
        }

        static string MoveLetters(string str)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    char nextChar = (char)(c + 1);

                    if (nextChar > 'z')
                    {
                        nextChar = 'a';
                    }
                    else if (nextChar > 'Z' && nextChar < 'a')
                    {
                        nextChar = 'A';
                    }

                    sb.Append(nextChar);
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
