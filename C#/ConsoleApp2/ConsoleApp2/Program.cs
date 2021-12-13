using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string hel = "hello";
            Dictionary<char, int> my_dict1 = new Dictionary<char, int>();
            foreach (var item in hel)
            {
                if (my_dict1.ContainsKey(item) == true)
                {
                    my_dict1[item] += 1;
                }
                else
                {
                    my_dict1.Add(item, 1);
                }

            }
            for (int i = 0; i < hel.Length; i++)
            {
                if (my_dict1[hel[i]] == 1)
                {
                    return i;
                }
            }

        }

       
    }
}
