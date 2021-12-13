
using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var api = new YouTubeApi();
            //    var videos = api.GetVideos("mosh");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Exception since divide by zero is not possible.
            //var cal = new Calculator();
            //cal.Divide(1,0);

            try
            {
                var cal = new Calculator();
                cal.Divide(1,0);
                //We go from specific to generic -> by look at the DivideByZeroException and its parent.
            }
            //We can call DivideByZeroException since we already import namespace system, usually without it, it have to be.
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
                
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("Arithematic Exception");
            }
            catch (SystemException e)
            {
                Console.WriteLine("System error");
            }

            //This is the parent exception of the dot.net framework.
            catch (Exception f)
            {
                Console.WriteLine("General Exception Error");
            }
            finally
            {
                Console.WriteLine("I got out of exception");
            }


            //object can be assign null without ? but for data type required.
            StreamReader reader = null;
            try
            {
                
                reader = new StreamReader(@"C:\Users\supaw\Documents\test2.txt");
                var content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid Error");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose();
                }


            }

            //USING ALSO CAN DO THE SAME JOB
            // When using the using keyword. Internally will create a finally block under the block that use dispose keyword.
            try
            {
                using (StreamReader reader2 = new StreamReader(@"C:\Users\supaw\Documents\test2.txt")) 
                {
                    var content = reader2.ReadToEnd();
                    Console.WriteLine(content);
                } 
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Exception, please try agian.");
            }


            //Creating and throwing your own exception
            YouTubeApi youtubeAPI = new YouTubeApi();
            List<Video> videos = youtubeAPI.GetVideos("Supavich");


        }
    }
}
