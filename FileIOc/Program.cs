using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Reading text file
            // path will be determined on where the file is saved
            string text = System.IO.File.ReadAllText(@"C:\Users\picha\Desktop\code\csharpnotes\FileIOc\text.txt");

            Console.WriteLine("Textfile contains following text: {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\picha\Desktop\code\csharpnotes\FileIOc\text.txt");

            Console.WriteLine("Contents of text.txt = ");
            foreach(string line in lines)
            {
                Console.WriteLine("\t {0}", line);
            }

            */

            /*
             * Writing text to file
             */

            // method 1
            string[] lines = { "first", "second", "third" };

            File.WriteAllLines(@"C:\Users\picha\Desktop\code\csharpnotes\FileIOc\text.txt", lines);

            // method 2
            //Console.WriteLine("Please give the file a name");
            //string fileName = Console.ReadLine();
            //Console.WriteLine("Pleaase enter the text for the file");
            //string input = Console.ReadLine();
            //File.WriteAllText(@"C:\Users\picha\Desktop\code\csharpnotes\FileIOc\" + fileName + ".txt", input);

            // method 3
            using (StreamWriter file = new StreamWriter(@"C:\Users\picha\Desktop\code\csharpnotes\FileIOc\newText.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
