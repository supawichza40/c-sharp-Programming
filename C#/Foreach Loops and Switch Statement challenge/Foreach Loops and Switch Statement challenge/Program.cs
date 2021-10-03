using System;

namespace Foreach_Loops_and_Switch_Statement_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first input?");
            string firstInput = Console.ReadLine();
            Console.WriteLine("What is the Data type");
            Console.WriteLine("Press 1 for String\nPress 2 for Integer\nPress 3 for Boolean");
            Console.WriteLine("What is your input?");
            string secondInput = Console.ReadLine();
            bool isValid = true;

            switch (secondInput)
            {
                case "1":
                    isValid = isAlphabetic(firstInput);
                    if (isValid == true)
                    {
                        Console.WriteLine("This is a valid String");
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid String");
                    }
                    break;
                case "2":
                    isValid = Int32.TryParse(firstInput, out int result);
                    if (isValid == true)
                    {
                        Console.WriteLine("This is a valid Integer");
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid Integer");
                    }
                    break;

                case "3":
                    isValid = bool.TryParse(firstInput, out bool resultBool);
                    if (isValid = true)
                    {
                        Console.WriteLine("This is a valid boolean");
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid boolean");
                    }
                    break;
                default:
                    break;
            }
            //Version 2
            //switch (secondInput)
            //{
            //    case "1":
            //        Console.WriteLine("This is a valid:String");
            //        break;
            //    case "2":
            //        isValid = int.TryParse(firstInput, out int result);
            //        if (isValid == true)
            //        {
            //            Console.WriteLine("The first input {0} is a valid Integer type",result);
            //        }
            //        else
            //        {
            //            Console.WriteLine("This is not a valid Integer type");
            //        }
            //        break;
            //    case "3":
            //        isValid = bool.TryParse(firstInput, out bool boolResult);
            //        if (isValid ==true)
            //        {
            //            Console.WriteLine("The firstInput {0} is a valid boolean",boolResult);

            //        }
            //        else
            //        {
            //            Console.WriteLine("This is not a valid boolean");
            //        }
            //        break;

            //    default:
            //        break;
            //}
        }

        public static bool isAlphabetic(string firstInput)
        {
            foreach (char alphabet in firstInput)
            {
                if (!char.IsLetter(alphabet))
                {
                    return false;
                }

            }
            return true;
        }

    }
}
