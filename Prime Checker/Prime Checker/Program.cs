namespace Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number to check if it's prime: ");
                int number = int.Parse(Console.ReadLine());

                bool isPrime = CheckPrime(number);

                if (isPrime)
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }

                Console.WriteLine("Do you want to check another number? (yes/no)");
                string response = Console.ReadLine().ToLower();

                if (response != "yes")
                {
                    break;
                }
            } while (true);
        }

        static bool CheckPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            if ((number % 2) == 0)
            {
                return false;
            }

            int sqrt = (int)Math.Sqrt(number);

            for (int i = 3; i < sqrt; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
