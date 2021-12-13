using System;
using System.Collections.Generic;

namespace ICalculatorInputService
{
    //interface IkeyBoard
    //{
    //    string GetNextTokenFromKeyBoard();
    //}

    //class KeyBoardReader : IkeyBoard
    //{
    //    public string GetNextTokenFromKeyBoard()
    //    {
    //        Console.WriteLine("Enter something");
    //        return Console.ReadLine().Ge
    //    }
    //}


    /// <summary>
    /// Gets the input from keyboard input an d return tokens
    /// </summary>
    class UserInput : IUserInput
    {
        //IkeyBoard _reader = null; 
        //public UserInput(IkeyBoard reader)
        //{
        //    _reader = reader;
        //}
        public List<string> GetInput()
        {
            //Console.WriteLine("Enter something");
            //string tokens = Console.ReadLine();

            //var arr = tokens.Split(' ');

            //return new List<string>(arr);
            List<string> x = new List<string> { "1", "+", "3" };
            return x;


        }
    }
}
