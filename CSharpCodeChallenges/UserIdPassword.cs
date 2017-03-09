using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeChallenges
{
    /// <summary>
    /// program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
    /// </summary>
    public static class UserIdPassword
    {
        public static void TestSignIn()
        {
            SignIn();
        }

        private static void SignIn()
        {
            string userName = "Microsoft";
            string password = "password";
            bool isWorngPassword = false;

            Console.WriteLine("Please enter userName.");
            string user = Console.ReadLine();
            if (!user.Equals(userName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("No user found with user name: {0}", user);
            }
            else
            {
                Console.WriteLine("Password:");
                for(int i =0; i < 3; i++)
                {
                    string pass = Console.ReadLine();
                    if (pass.Equals(password))
                    {
                        isWorngPassword = false;
                        Console.WriteLine("Hi Microsoft");
                        break;
                    }
                    else
                    {
                        isWorngPassword = true;
                        Console.WriteLine("Wrong password.");
                    }
                }
            }

            if (isWorngPassword)
            {
                Console.WriteLine("You are blocked due to consecutive invalid try.");
            }
        }
    }
}
