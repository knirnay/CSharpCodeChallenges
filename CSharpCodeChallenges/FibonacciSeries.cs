namespace CSharpCodeChallenges
{
    using System;

    public static class FibonacciSeries
    {
        public static void PrintFibonacciSeries(int howManyNumberInSeries)
        {
            Console.WriteLine("Fibonacci series.");
            for (int i = 0; i < howManyNumberInSeries; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }

        public static void PrintReverseFibonacciSeries(int howManyNumberInSeries)
        {
            Console.WriteLine("Reverse fibonacci series.");
            for (int i = howManyNumberInSeries - 1; i >= 0; i--)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }

        /// <summary>
        /// Fibonaccis the specified n.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        private static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = b + temp;
            }

            return a;
        }
    }
}
