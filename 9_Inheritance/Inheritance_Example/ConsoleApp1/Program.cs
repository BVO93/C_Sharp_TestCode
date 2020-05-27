using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Post post1 = new Post("Thanks for birthday wishes", true, "BjornDaBoy");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check shoes", "BVO", "Https//images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Check the vid", "JJ", "HTTP.youtube",20 , true);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop vid");

            Console.ReadKey();
            videoPost1.Stop();

            
        }
    }
}
