using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            string ageString;
            //try this code to make sure valid age is given.
            try
            {
                //get string from user and convert to int.
                Console.WriteLine("enter your age: ");
                ageString = Console.ReadLine();
                int ageInt = int.Parse(ageString);

                Console.WriteLine(ageInt);
                //manually thowing an exception.
                //throw new Exception("boom"); 
            }
            //if invalid, catch the exception and do this code.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);


            }
            //finally will always run code regardless.
            finally
            {
                Console.WriteLine("This message Finally DISPLAYED.");
            }

        }
    }
}
