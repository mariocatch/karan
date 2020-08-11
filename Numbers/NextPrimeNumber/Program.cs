using System;

namespace NextPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctr = 1;
            Console.WriteLine("Press enter for next prime number. Press Escape to stop");
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                while (!IsPrime(ctr))
                {
                    ctr++;
                }
                Console.Write($"{ctr}, ");
                ctr++;
            }
        }

        static bool IsPrime(int n)
        {
            if (n == 1 || n == 2)
                return true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0 && n != i)
                    return false;
            }

            return true;
        }
    }
}
