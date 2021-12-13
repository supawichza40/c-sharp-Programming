using System;
using System.IO;

namespace ReadToAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\supaw\Documents\c-sharp-Programming\C#\ReadToAFile\ReadToAFile\File2.txt";
            FileStream stream = null;

            try
            {
                
                string userInput = "";
                stream = new FileStream(path, FileMode.OpenOrCreate);
                

                using (StreamWriter writer = new StreamWriter(stream))
                {

                    writer.WriteLine("1");
                    writer.WriteLine("2");
                    writer.WriteLine("3");
                    writer.WriteLine("4");
                    writer.WriteLine("5");
                    //Console.WriteLine("What would you like to save to a file?");
                    //userInput = Console.ReadLine();

                
                }
                
                
            }
            finally
            {
                if (stream!=null)
                {
                    stream.Dispose();
                }
            }
            //Read a file
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            stream = new FileStream(path, FileMode.Open);
            using (StreamReader reader = new StreamReader(stream))
            {
                string line = "";
                while (line != null)
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                }
                
            }
            
        }
    }
}
