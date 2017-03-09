using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeChallenges
{
    public static class MultiDimensionalArray
    {
        public static void AddTwoMatricesOfSameSize()
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            int[,] arr1 = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] arr2 = new int[,] { { 5, 6 }, { 7, 8 } };
            int[,] arr3 = new int[2, 2];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        public static void FindTransposeOfMetrix()
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] transpose = new int[arr.GetLength(1), arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    transpose[j, i] = arr[i, j];
                }
            }

            Console.WriteLine("Input array.");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Transposed array.");
            for (int i = 0; i < transpose.GetLength(0); i++)
            {
                for (int j = 0; j < transpose.GetLength(1); j++)
                {
                    Console.Write(transpose[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        public static void SumOfRightDiagonalOfMatrix()
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            int sum = 0;
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                    if (i == j)
                    {
                        sum += arr[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        public static void SumOfLeftDiagonalMatrix()
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            int sum = 0;
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = arr.GetLength(1) - 1 - i; j >= 0; j--)
                {
                    sum += arr[i, j];
                    break;
                }
            }

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        public static void SumOfRowAndColumn()
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Printing array elements.");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }

                Console.WriteLine("Sum of row {0} is {1}", i, sum);
            }

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sum += arr[j, i];
                }

                Console.WriteLine("Sum of row {0} is {1}", i, sum);
            }
            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        public static void SetUpperLeftTriangularZero()
        {
            Console.WriteLine("Entering method:{0}", MethodBase.GetCurrentMethod().Name);
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Printing array elements.");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1 - i; j++)
                {
                    arr[i, j] = 0;
                }
            }

            Console.WriteLine("Printing array elements after triangular zero set.");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j< arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        public static void SetLowerLeftTriangularZero()
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            int[,] arr = new int[3, 3] { { 1, 2, 3, }, { 2, 3, 4 }, { 4, 5, 6 } };
            Console.WriteLine("Printing array elements.");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                for (int i = arr.GetLength(0) - 1; i > j; i--)
                {
                    arr[i, j] = 0;
                }
            }

            Console.WriteLine("Printing array elements after triangular zero set.");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        public static void SetUpperRightTriangularZero()
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            Console.WriteLine("Printing array elements.");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = arr.GetLength(1) - 1; j > i; j--)
                {
                    arr[i, j] = 0;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Printing array elements after triangular zero set.");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        public static void DeterminantOf3By3Matrix()
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            int[,] arr = new int[3, 3] { { 1, 0, -1 }, { 0, 0, 1 }, { -1, -1, 0 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                }
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        public static void FindIfTheMatrixIsIdentity()
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            bool isIdentity = false;
            int[,] arr = new int[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (arr[i,j] != 1)
                        {
                            isIdentity = false;
                            break;
                        }
                        else
                        {
                            isIdentity = true;
                        }
                    }
                    else
                    {
                        if(arr[i,j] != 0)
                        {
                            isIdentity = false;
                            break;
                        }
                        else
                        {
                            isIdentity = true;
                        }
                    }
                }
            }

            Console.WriteLine("IsIdentity matrix: {0}", isIdentity);
            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }
    }
}
