using System.Collections.Generic;
using System.Data;

namespace CalculatorApp
{
    class ProcessInput : IProcessInput
    {
        public int CalculateInput(List<string> lis_input)
        {
            int result = 0;
            string expression = "";
            DataTable dt = new DataTable();
            expression = $"{lis_input[0]}{lis_input[1]}{lis_input[2]}";
            for (int i = 0; i < lis_input.Count-2; i+=2)
            {
                if (i< 2)
                {
                    expression = $"{lis_input[0]}{lis_input[1]}{lis_input[2]}";
                    var val = dt.Compute(expression, "");
                    result = (int)val;
                    continue;
                }
                expression = $"{result}{lis_input[i + 1]}{lis_input[i + 2]}";
                var r = dt.Compute(expression, "");
                result = (int)r;
            }
            return result;
        }
    }
}
