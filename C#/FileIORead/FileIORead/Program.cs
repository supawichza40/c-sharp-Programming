using System;

namespace FileIORead
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Reading all text
            string text = System.IO.File.ReadAllText(@"C:\Users\supaw\source\repos\FileIORead\FileIORead\intro.txt");
            Console.WriteLine("Text file contain following text {0}",text);

            //2.Reading Line by line
            string[] allTextLine = System.IO.File.ReadAllLines(@"C:\Users\supaw\source\repos\FileIORead\FileIORead\intro.txt");
            Console.WriteLine("This is another way of reading from file");
            foreach (string item in allTextLine)
            {
                Console.WriteLine(item);
            }


            //Writing to a file.
            //1.
            string[] allLineToWrite = {
                "This is line 1 third",
                "This is line 2",
                "This is line 3"};

            System.IO.File.WriteAllLines(@"C:\Users\supaw\source\repos\FileIORead\FileIORead\newText.txt", allLineToWrite);
            string input = Console.ReadLine();
            //2.
            System.IO.File.WriteAllText(@"C:\Users\supaw\source\repos\FileIORead\FileIORead\newText.txt", input);//this will overwrite the existing file.
            //3. StreamWriter
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\supaw\source\repos\FileIORead\FileIORead\newText2.txt"))//This one we can append new data to it.
            {
                foreach (string line in allLineToWrite)
                {
                    if (line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}
