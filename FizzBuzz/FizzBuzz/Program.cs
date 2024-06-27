namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            string[] result = FizzBuzz(n);

            Console.WriteLine("FizzBuzz result: ");
            Console.WriteLine();

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }

        static string[] FizzBuzz(int n)
        {
            List<string> answer = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5  == 0)
                {
                    answer.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    answer.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    answer.Add("Buzz");
                }
                else
                {
                    answer.Add(i.ToString());
                }
            }

            return answer.ToArray();
        }
    }
}
