using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningMethods
{
    class Program
    {
        //page50
        static double readValue(string prompt, double low, double high)
        {
            double res = 0;
            do
            {
                Console.WriteLine(prompt + "between " + low + " and " + high);
                string resultString = Console.ReadLine();
                res = double.Parse(resultString);

            } while (res < low || res > high);
            return res;
        }

        const double MAX_WIDTH = 5.0;
        const double MIN_WIDTH = 0.5;


        static void Main(string[] args)
        {
            double windowWidth = readValue("Enter width of window: ", MIN_WIDTH, MAX_WIDTH);
            Console.WriteLine("width is: " + windowWidth);

            double age = readValue("enter age: ", 0, 70);
            Console.WriteLine("age is : " + age);
            Console.ReadLine();
        }

        static void AddOneToRefParam(ref int i)
        {
            i++;
            Console.WriteLine("i is: " + i);
        }
    }
}