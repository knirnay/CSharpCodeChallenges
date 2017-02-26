namespace CSharpCodeChallenges
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A palindrome is a word that reads the same backward or forward. 
    /// Write a function that checks if a given word is a palindrome. 
    /// Character case should be ignored. For example, IsPalindrome("Deleveled") should return 
    /// true as character case should be ignored, resulting in "deleveled", which is a palindrome 
    /// since it reads the same backward and forward.
    /// </summary>
    public static class Palindrome
    {
        public static void TestPalindrome()
        {
            Console.WriteLine("did is palindrome: {0}", IsPalindrome("did"));
            Console.WriteLine("Did is palindrome: {0}", IsPalindrome("Did"));
            Console.WriteLine("Nirnay is Palindrome: {0}", IsPalindrome("Nirnay"));
            Console.WriteLine("Hinal is palindrome: {0}", IsPalindrome("Hinal"));
            Console.WriteLine("Deleveled is palindrome: {0}", IsPalindrome("Deleveled"));
        }

        /// <summary>
        /// Determines whether the specified word is palindrome.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns></returns>
        public static bool IsPalindrome(string word)
        {
            IEnumerable<char> chars = word.Reverse();
            string reverseWord = new string(chars.ToArray());
            if (word.Equals(reverseWord, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }
    }
}
