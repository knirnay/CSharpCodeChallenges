using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeChallenges
{
    public static class WordCounter
    {
        public static void TestCountWords()
        {
            string paragraph = @"The Task class represents a single operation that does not return a value and that usually executes asynchronously. 
Task objects are one of the central components of the task-based asynchronous pattern first introduced in the .NET Framework 4. 
Because the work performed by a Task object typically executes asynchronously on a thread pool thread rather than synchronously on the main 
application thread, you can use the Status property, as well as the IsCanceled, IsCompleted, and IsFaulted properties, 
to determine the state of a task. Most commonly, a lambda expression is used to specify the work that the task is to perform.";

            int count = CountWords(paragraph);
            Console.WriteLine("There are {0} words in the paragraph", count);
        }
        /// <summary>
        /// Counts the words.
        /// </summary>
        /// <param name="paragraph">The paragraph.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static int CountWords(string paragraph)
        {
            if (paragraph == null)
            {
                throw new ArgumentNullException(nameof(paragraph));
            }

            return paragraph.Split(' ').Length;
        }
    }
}
