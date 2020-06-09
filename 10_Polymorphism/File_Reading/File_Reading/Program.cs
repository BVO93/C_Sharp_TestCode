using System;
using System.IO;

namespace File_Reading
{
    class Program
    {
        static void Main(string[] args)
        {
            //WRITING 
            //Method 1
            string[] lines = { "First 250", " Second 242", "Third 240"};
            File.WriteAllLines(@"D:\1_Programming\1_C#\MasterClass\1_C#_SmallProjects\10_Polymorphism\File_Reading\File_Reading\highscores.txt", lines);

            /*
            // Method 2
            Console.WriteLine("Give filename");
            string fileName = Console.ReadLine();
            Console.WriteLine("Give file content");
            string input = Console.ReadLine();
            File.WriteAllText(@"D:\1_Programming\1_C#\MasterClass\1_C#_SmallProjects\10_Polymorphism\File_Reading\File_Reading\" + fileName + ".txt", input);
            */

            // Method 3
            using(StreamWriter file = new StreamWriter(@"D:\1_Programming\1_C#\MasterClass\1_C#_SmallProjects\10_Polymorphism\File_Reading\File_Reading\wr.txt"))
            {
                foreach(string line in lines)
                {
                    if(line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }


            using(StreamWriter file = new StreamWriter(@"D:\1_Programming\1_C#\MasterClass\1_C#_SmallProjects\10_Polymorphism\File_Reading\File_Reading\highscores.txt", true))
            {
                file.WriteLine("Extra line");
            }

            // READING
                /*
                // Reading text in total
                string text = System.IO.File.ReadAllText(@"D:\1_Programming\1_C#\MasterClass\1_C#_SmallProjects\10_Polymorphism\File_Reading\File_Reading\test.txt");
                Console.WriteLine("Text file contains : {0}", text);

                // reading lines 
                string[] lines = System.IO.File.ReadAllLines(@"D:\1_Programming\1_C#\MasterClass\1_C#_SmallProjects\10_Polymorphism\File_Reading\File_Reading\test.txt");
                Console.WriteLine("Contents of textfile.txt =  ");
                foreach(string line in lines)
                {
                    Console.WriteLine("\t" + line);
                }

                */

        }
    }
}
