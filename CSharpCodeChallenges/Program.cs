using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCodeChallenges.BinaryTreeSearch;
using CSharpCodeChallenges.UserInput;

namespace CSharpCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciSeries.PrintFibonacciSeries(15);
            FibonacciSeries.PrintReverseFibonacciSeries(15);
            Palindrome.TestPalindrome();
            BinaryTreeSearcher.TestBinaryTreeTravers();
            FizzBuzz.PrintFizzBuzzResult(100);
            TestUserInput.PrintUserInput();
            Console.WriteLine("Press any key to continues...");
            Console.ReadKey();
        }
    }
}
