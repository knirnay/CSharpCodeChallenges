using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeChallenges
{
    public static class Arrays
    {
        public static void ReadArrayElementFromConsole()
        {
            int[] arr = new int[10];
            Console.WriteLine("Read and print array elements.");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Input {0} elements of array.", arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("elemment - {0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Print array elements.");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write("\t");
            }

            Console.WriteLine();
            Console.WriteLine("Print array elements revers.");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write("\t");
            }
        }

        public static void SumArrayElements()
        {
            int[] arr = new int[10];
            Console.WriteLine("Read and print array element.");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Input {0} elements of array.", arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("elements - {0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Print array elements.");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write("\t");
            }

            Console.WriteLine();
            Console.WriteLine("Sum of array elements.");
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);

        }

        public static void CopyArray()
        {
            int[] arr1 = new int[50];
            int[] arr2 = new int[arr1.Length];

            Console.WriteLine("Copy one array into another.");

            arr1 = Enumerable.Range(0, 50).ToArray<int>();
            for(int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("Are two arrays equal? {0}", arr1.SequenceEqual(arr2));
        }

        public static void DuplicateElementInArray()
        {
            int counter = 0;
            int[] arr = new int[5] { 2, 6, 5, 2, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                        Console.WriteLine("element {0} = {1} same as element {2} = {3}", i, arr[i], j, arr[j]);
                        break;
                    }
                }
            }

            Console.WriteLine("Total duplicate element in an array: {0}", counter++);
        }


        public static void GetUniqueElementInArray()
        {
            bool isDuplicate = false;
            int[] arr = new int[10] { 1, 4, 1, 7, 4, 5, 6, 8, 0, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        isDuplicate = true;
                        break;
                    }
                    else
                    {
                        isDuplicate = false;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine("element {0} = {1} is unique.", i, arr[i]);
                }
            }
        }

        public static void MergeArrayAccendingOrder()
        {
            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = new int[3] { 1, 2, 3 };
            int[] arr3 = new int[arr1.Length + arr2.Length];

            for(int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }

            for (int i = 0, j = arr1.Length; i < arr2.Length; i++, j++)
            {
                arr3[j] = arr2[i];
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3.Length - 1; j++)
                {
                    if (arr3[j] >= arr3[j + 1])
                    {
                        int temp = arr3[j + 1];
                        arr3[j + 1] = arr3[j];
                        arr3[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i]);
                Console.Write("\t");
            }
        }

        public static void GetFrequecyOfEachElement()
        {
            int[] arr = new int[5] { 1, 4, 1, 6, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }

                for (int j = i+1; j< arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }

                Console.WriteLine("Frequency of element {0} is {1}", arr[i], counter);
            }
        }

        public static void GetMaxAndMinValueFromArray()
        {
            int[] arr = new int[5] { 3, 6, 3, 9, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] >= arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Minimun element value: {0}", arr[0]);
            Console.WriteLine("Maximum element value: {0}", arr[arr.Length - 1]);

            // Another way of getting max and min;

            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Maximum element value: {0}", max);
            Console.WriteLine("Minimum element value: {0}", min);
        }

        public static void GenerateOddEvenNumberArraysFromArray()
        {
            int[] arr = new int[5] { 2, 5, 7, 6, 8 };
            int even = 0;
            int odd = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            int[] evenArray = new int[even];
            int[] oddArray = new int[odd];
            int j = 0;
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArray[j] = arr[i];
                    j++;
                }
                else
                {
                    oddArray[k] = arr[i];
                    k++;
                }
            }

            foreach(int i in evenArray)
            {
                Console.Write(i);
                Console.Write("\t");
            }

            Console.WriteLine();
            foreach(int i in oddArray)
            {
                Console.Write(i);
                Console.Write("\t");
            }

            Console.WriteLine();
        }

        public static void SortArrayElementDecending()
        {
            int[] arr = new int[5] { 4, 2, 7, 9, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] <= arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            foreach (int i in arr)
            {
                Console.Write(i);
                Console.Write("\t");
            }

            Console.WriteLine();
        }
    }
}
