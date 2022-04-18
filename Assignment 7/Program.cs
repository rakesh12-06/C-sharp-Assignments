using System;
using System.IO;
namespace filesystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"/Users/assignments/Desktop/demo.txt");
            foreach (string line in lines)
                Console.WriteLine(line);

            string path = @"/Users/assignments/Desktop/demo.txt";
            FileInfo fl = new FileInfo(path);
            //File.Create(path);// overwrites above file
            {
                Console.WriteLine("File has been created");
            }
            StreamWriter str = fl.CreateText();
            str.WriteLine("hello");
            Console.WriteLine("File has been created with text");

            fl.Delete();
            Console.WriteLine("File has been deleted");


            String way = @"/Users/assignments/Desktop/hello";
            DirectoryInfo fi = new DirectoryInfo(way);
            fi.Create();
            {
                Console.WriteLine("Directory has been created");
            }
        }
    }
}
