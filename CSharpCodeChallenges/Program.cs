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
            MostUsedWords.TestMostUsedWords();
            WordCounter.TestCountWords();
            Arrays.CopyArray();
            Arrays.DuplicateElementInArray();
            Arrays.GetUniqueElementInArray();
            Arrays.MergeArrayAccendingOrder();
            Arrays.GetFrequecyOfEachElement();
            Arrays.GetMaxAndMinValueFromArray();
            Arrays.GenerateOddEvenNumberArraysFromArray();
            Arrays.SortArrayElementDecending();
            MultiDimensionalArray.AddTwoMatricesOfSameSize();
            MultiDimensionalArray.FindTransposeOfMetrix();
            MultiDimensionalArray.SumOfRightDiagonalOfMatrix();
            MultiDimensionalArray.SumOfLeftDiagonalMatrix();
            MultiDimensionalArray.SumOfRowAndColumn();
            MultiDimensionalArray.SetUpperLeftTriangularZero();
            MultiDimensionalArray.SetLowerLeftTriangularZero();
            MultiDimensionalArray.SetUpperRightTriangularZero();
            MultiDimensionalArray.FindIfTheMatrixIsIdentity();
            Convertor.TestTempratureConversion();
            ShapeDisplay.TestShapeDisplay();
            UserIdPassword.TestSignIn();
            Console.WriteLine("Press any key to continues...");
            Console.ReadKey();
        }
    }
}
