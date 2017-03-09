using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeChallenges
{
    public static class Convertor
    {
        public static void TestTempratureConversion()
        {
            Console.WriteLine("100 degree celsius equals to {0} kelvin.", CelsiusToKelvin(100));
            Console.WriteLine("100 degree clesius equals to {0} fahrenheit.", CelsiusToFahrenheit(28));
            Console.WriteLine("Binary value of 25 is {0}", DecimalToBinary(25));
        }
        private static double CelsiusToKelvin(double degreeCelsius)
        {
            return degreeCelsius + 273.15;
        }

        private static double CelsiusToFahrenheit(double degreeCelsius)
        {
            return (degreeCelsius * ((double)9 / (double)5)) + 32;
        }

        private static string DecimalToBinary(int number)
        {
            Console.WriteLine("Entering method: {0}", MethodBase.GetCurrentMethod().Name);
            StringBuilder sb = new StringBuilder();
            while(number > 1)
            {
                int result = number % 2;
                sb.Append(result);
                number = number / 2;
            }

            sb.Append(number);
            Console.WriteLine("Exiting method: {0}", MethodBase.GetCurrentMethod().Name);
            IEnumerable<char> binary = sb.ToString().Reverse();
            return new string(binary.ToArray());
        }
    }
}
