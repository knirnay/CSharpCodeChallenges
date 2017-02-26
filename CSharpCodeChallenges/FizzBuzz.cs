namespace CSharpCodeChallenges
{
    using System;
    using System.Globalization;

    /// <summary>
    /// The player designated to go first says the number "1", 
    /// and each player thenceforth counts one number in turn. 
    /// However, any number divisible by three is replaced by 
    /// the word fizz and any divisible by five by the word buzz.
    /// Numbers divisible by both become fizz buzz.
    /// </summary>
    public static class FizzBuzz
    {
        /// <summary>
        /// Prints the fizz buzz result.
        /// </summary>
        /// <param name="maxNum">The maximum number.</param>
        public static void PrintFizzBuzzResult(int maxNum)
        {
            for (int i = 1; i < maxNum; i++)
            {
                Console.WriteLine(GetFizzBuzz(i));
            }
        }

        /// <summary>
        /// Gets the fizz buzz.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public static string GetFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}
