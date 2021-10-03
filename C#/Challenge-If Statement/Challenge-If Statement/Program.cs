using System;

namespace Challenge_If_Statement
{
    class Program
    {
        /*
         * Create a user Login System, where the user can first register and then Login in. The Program should check if the user has entered the correct username and password, 
         * wenn login in (so the same ones that he used when registering).
As we haven't covered storing data yet, just create the program in a way, that registering and logging in, happen in the same execution of it.
User If statements and User Input and Methods to solve the challenge.
        */
        static void Main(string[] args)
        {
            string username = "", password = "";
            while (true)
            {
               
                Console.WriteLine("What would you like to do? 1.Register 2.LogIn 3.Exit");
                string userOption = Console.ReadLine();
                int userOptionNumber;
                bool validInputNumber = Int32.TryParse(userOption, out userOptionNumber);

                if (validInputNumber)
                {
                    if (userOptionNumber == 1)
                    {
                        Console.WriteLine("You are in the Registering Page!");
                        Console.WriteLine("What is your username? ");
                        username = Console.ReadLine();
                        Console.WriteLine("What is your password?");
                        password = Console.ReadLine();

                        Console.WriteLine("Your account has been activated!");
                    }
                    else if (userOptionNumber == 2)
                    {
                        string usernameInput, passwordInput;
                        Console.WriteLine("You are in Log In page");
                        Console.WriteLine("What is your username?");
                        usernameInput = Console.ReadLine();
                        Console.WriteLine("What is your password?");
                        passwordInput = Console.ReadLine();
                        bool isLogin = LogIn(username, password, usernameInput, passwordInput);
                        if (isLogin)
                        {
                            Console.WriteLine("You have successfully Log In");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Log In Detail, please register or sign in again!");
                        }
                    }
                    else if (userOptionNumber == 3)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input from user, please key in only numeric value");
                }

            }
        }

        public static bool LogIn(string username,string password,string userUsername,string userPassword)
        {
            if (username.Equals(userUsername) && password.Equals(userPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
