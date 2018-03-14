using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingFiles
{
    class Program
    {//page 73 - using files
        static void Main(string[] args)
        {

            string path;
            path = @"C:\Users\Asus\Desktop\programming\usingfiles.txt";

            //create writer object
            StreamWriter writer;
            writer = new StreamWriter(path);//file name
            writer.WriteLine("writing to thing1");//what to write.
            writer.WriteLine("writing to thing2");
            writer.WriteLine("writing to thing3");
            writer.WriteLine("writing to thing4");
            writer.WriteLine("writing to thing5");
            writer.Close();//execute the write and close the stream.

            //reading from the file we created/
            Console.WriteLine(path);
            StreamReader reader;
            reader = new StreamReader(path);
            string line = reader.ReadLine();
            Console.WriteLine(line);
            line = reader.ReadLine();//add more to read second line.
            Console.WriteLine(line);
            reader.Close();//ALWAYS CLOSE

            //loop through till the end of the end of stream is reached.
            Console.WriteLine("while loop read");

            StreamReader EOL = new StreamReader(path);
            while (EOL.EndOfStream == false)
            {
                string theline = EOL.ReadLine();
                Console.WriteLine(theline);
            }
            EOL.Close();//ALWAYS CLOSE

            //using readtoend - is faster and shorter. 
            Console.WriteLine("read to end read - fastest");
            StreamReader fasterway = new StreamReader(path);
            string E = fasterway.ReadToEnd();
            Console.WriteLine(E);
            fasterway.Close();//ALWAYS CLOSE
        }
    }
}
