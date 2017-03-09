using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeChallenges
{
    public class MostUsedWords
    {
        /// <summary>
        /// Tests the most used words.
        /// </summary>
        public static void TestMostUsedWords()
        {
            string paragraph = @"A sorting operation orders the elements of a sequence based on one or more attributes. The first sort criterion performs a primary sort on the elements. By specifying a second sort criterion, you can sort the elements within each primary sort group.
The following illustration shows the results of an alphabetical sort operation on a sequence of characters.";
            IEnumerable<KeyValuePair<string, int>> sortedData = GetMostUsedWords(paragraph);
            foreach(KeyValuePair<string, int> data in sortedData)
            {
                Console.WriteLine("Word: {0} is used {1} times.", data.Key, data.Value);
            }
        }

        /// <summary>
        /// Gets the most used words.
        /// </summary>
        /// <param name="paragraph">The paragraph.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEnumerable<KeyValuePair<string, int>> GetMostUsedWords(string paragraph)
        {
            if (paragraph == null)
            {
                throw new ArgumentNullException(nameof(paragraph));
            }

            Dictionary<string, int> unsortedData = new Dictionary<string, int>();
            string[] words = paragraph.Split(' ');
            
            foreach (string word in words)
            {
                int value;
                if (unsortedData.TryGetValue(word, out value))
                {
                    unsortedData[word] = value + 1;
                }
                else
                {
                    unsortedData.Add(word, 1);
                }
            }

            return from data in unsortedData
                   orderby data.Value descending
                   select data;
        }
    }
}
