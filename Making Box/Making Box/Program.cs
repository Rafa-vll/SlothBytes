using System.Threading.Channels;

namespace Making_Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entar a dimenson of the box: ");
            int dimension = int.Parse(Console.ReadLine());

            List<string> box = MakeBox(dimension);

            PrintBox(box);
        }

        static List<string> MakeBox(int n)
        {
            List<string> box = new List<string>();

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    string line = new string('#', n);
                    box.Add(line);
                }
                else
                {
                    string line = '#' + new string(' ', n - 2) + '#';
                    box.Add(line);
                }
            }
            return box;
        }

        static void PrintBox(List<string> box)
        {
            foreach (string line in box)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
        }
    }
}
