namespace Calculate_Damage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter damage per attack:");
            int damage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter attacks per second:");
            int speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter time unit (second, minute, hour):");
            string timeUnit = Console.ReadLine();

            int result = CalculateDamage(damage, speed, timeUnit);

            if (result == -1)
            {
                Console.WriteLine("Invalid input: damage or speed cannot be negative.");
            }
            else
            {
                Console.WriteLine($"Total damage after {timeUnit}: {result}");
            }
        }

        static int CalculateDamage(int damage, int speed, string timeUnit)
        {
            if (damage < 0 || speed < 0)
            {
                return -1;
            }

            int seconds = 0;

            switch (timeUnit.ToLower())
            {
                case "second":
                    seconds = 1;
                    break;
                case "minute":
                    seconds = 60;
                    break;
                case "hour":
                    seconds = 3600;
                    break;
                default:
                    return -1;
            }

            int damagePerSecond = damage * speed;
            return damagePerSecond * seconds;
        }
    }
}
