using System;

namespace Inheritance_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes",true,"Supavich Aussawa");
            Console.WriteLine(post1.ToString());
            
            Post post2 = new Post("Thank for", true, "Superman");
            Console.WriteLine(post2.ToString());
            ImagePost post3 = new ImagePost("The Image", "Superman Aussawa", "https://www.google.com/imghp?hl=en", true);
            Console.WriteLine(post3.ToString());
            VideoPost post4 = new VideoPost("The Video", "Superman again", "https://www.google.com", true,10);

            Console.WriteLine(post4.ToString());
            post4.Play();
            Console.WriteLine("Press anything to continue");
            Console.ReadLine();
            post4.Stop();
        }

    }
}
