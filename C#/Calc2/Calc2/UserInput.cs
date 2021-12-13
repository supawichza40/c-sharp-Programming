using System;
using System.Collections.Generic;

namespace ICalculatorInputService
{
    interface IkeyBoardReader
    {
        string GetNextTokenFromKeyBoard();
    }

    class KeyBoardReader : IkeyBoardReader
    {
        public string GetNextTokenFromKeyBoard()
        {
            Console.WriteLine("Enter something");
            return Console.ReadLine();
        }
    }


    /// <summary>
    /// Gets the input from keyboard input an d return tokens
    /// </summary>
    class UserInput : IUserInput
    {
        IkeyBoardReader _reader = null;
        public UserInput(IkeyBoardReader reader)
        {
            _reader = reader;
        }
        public List<string> GetInput()
        {
            ValidateUserInput v = new ValidateUserInput();
            
            List<string> lis = new List<string>();
            string token = _reader.GetNextTokenFromKeyBoard();
            while(token !=" ")
            {
                if (token != " " && v.ValidInput(token)&&v.IsCorrectSequence(token,lis.Count) )
                {
                    lis.Add(token);
                }
                token = _reader.GetNextTokenFromKeyBoard();
                
            }



            return lis;
            


        }
    }
}
