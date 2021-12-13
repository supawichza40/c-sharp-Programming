using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            string numberOfInput = Console.ReadLine();
            string array_input = Console.ReadLine();
            string[] array_num_str = array_input.Split(" ");
            int[] array_num = new int[array_num_str.Length];
            int counter = 0;
            foreach (var item in array_num_str)
            {
                array_num[counter] = Convert.ToInt32(item);
                counter += 1;
            }
        }
      


        

    }
}
