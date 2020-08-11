using System;
using System.Collections.Generic;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var number in GetFibonacciSequence(50))
            {
                Console.Write($"{number} ");
            }
        }

        private static IEnumerable<int> GetFibonacciSequence(int n)
        {
            int n1 = 0;
            int curr = 1;

            while (curr <= n)
            {
                yield return curr;
                int n2 = n1;
                n1 = curr;
                curr = n2 + n1;
            }
        }
    }
}
