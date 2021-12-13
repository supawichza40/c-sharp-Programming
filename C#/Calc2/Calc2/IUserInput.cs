using System.Collections.Generic;

namespace ICalculatorInputService
{
    /// <summary>
    /// This class will get user input from an input device 
    /// //and return the tokens as a List
    /// </summary>
    interface IUserInput
    {
        List<string> GetInput();
    }
}
