using CalculatorApp;
using System;

class ValidateUserInput : IValidateUserInput,IValidSequence
{
    public bool IsCorrectSequence(string s,int count)
    {
        //Odd number=> operator
        if (count % 2 == 1)
        {
            if ("+ - * /".Contains(s))
            {
                return true;
            }
            return false;
        }
        else
        {
            if (Int32.TryParse(s,out int result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public bool ValidInput(string val)
    {
        if ("+ - * /".Contains(val))
        {
            return true;
        }
        if (Int32.TryParse(val, out int result))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}