using System;
using System.Numerics;

namespace EtotheNthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = CalculateE(27);
            Console.WriteLine(answer);
        }

        static decimal CalculateE(int n)
        {
            if (n > 27)
                throw new ArgumentException("27 is the highest supported term for calculating E");

            decimal e = 1.0m;
            for (int i = 1; i <= n; i++)
            {
                e += 1 / (decimal)Factorial(i);
            }
            return e;
        }

        static BigInteger Factorial(BigInteger n)
        {
            if (n == 0)
                return 1;
            BigInteger total = n;
            for (BigInteger i = n - 1; i > 1; i--)
            {
                total *= i;
            }
            return total;
        }
    }
}