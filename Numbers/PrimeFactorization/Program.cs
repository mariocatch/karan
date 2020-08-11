using System;
using System.Collections.Generic;

namespace PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var number in GetPrimeFactors(53))
            {
                Console.Write($"{number} ");
            }
        }

        private static int[] GetPrimeFactors(int n)
        {
            var primeFactors = new List<int>();

            var curr = n;
            var skip = false;
            while (curr-- > 0)
            {
                if (curr % 2 != 0)
                {
                    for (int i = 3; i < curr; i++)
                    {
                        if (curr % i == 0 && curr != i)
                        {
                            skip = true;
                            break;
                        }
                    }
                    if (skip)
                    {
                        skip = false;
                    }
                    else
                    {
                        primeFactors.Add(curr);
                    }
                }
            }

            return primeFactors.ToArray();
        }
    }
}
