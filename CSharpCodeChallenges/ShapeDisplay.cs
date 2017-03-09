using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeChallenges
{
    public static class ShapeDisplay
    {
        public static void TestShapeDisplay()
        {
            InvertedRectangle(7);
            InvertedTriangle(5);
            Rectangle(5);
            RectangleIncrementingNumbers(5);
            RectagleFirstLoopNumbers(5);
            Triangle(5);
            Triangle1(5);
            Dimond(9);
        }

        private static void InvertedRectangle(int dimension)
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        private static void InvertedTriangle(int dimension)
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        private static void Rectangle(int dimension)
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        private static void RectangleIncrementingNumbers(int dimension)
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j + 1);
                }

                Console.WriteLine();
            }
            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        private static void RectagleFirstLoopNumbers(int dimension)
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i + 1);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        private static void Triangle(int dimension)
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            for (int i = 0; i < dimension; i++)
            {
                for (int j = dimension - 1; j >= 0; j--)
                {
                    if (i >= j)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        private static void Triangle1(int height)
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            for (int i = 0; i < height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2*i-1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }

        private static void Dimond(int width)
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            for (int i = 0; i < width/2 + 1; i++)
            {
                for(int j = 0; j <= width/2 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= 2*i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = width /2; i >= 0; i--)
            {
                for (int j = width / 2 - i + 1; j >= 0; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2*i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
        }
    }
}
