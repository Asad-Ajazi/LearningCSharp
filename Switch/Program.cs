using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {//page 70 switch statements.
        static void Main(string[] args)
        {
            //if user gave input of 2.
            int selection = 1;
            //create switch statement and pass selection int for case number.
            switch (selection)
            {
                //case 1 calls method1.
                case 1:
                    method1();
                    break;//breaks out out to the end of switch- is required
                case 2:
                    method2();
                    break;
                //it is possible to use multiple cases for a switch.
                case 3:
                case 333:
                    method3();
                    break;
                //possible to use other types to read from aswell.
                //if useing strings. call toupper or tolower to make easier.
                /*case "stringCase":
                    Console.WriteLine("hi");
                    break;*/
                default: //default case runs if invalid case is called.
                    Console.WriteLine("default value, you didnt give valid case.");
                    break;
            }
        }

        static void method1()
        {
            Console.WriteLine("this is method 1");
        }
        static void method2()
        {
            Console.WriteLine("this is method 2");
        }
        static void method3()
        {
            Console.WriteLine("this is method 3");
        }
    }
}
