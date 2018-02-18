using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsole //will be used to test small sections of code.
{

    class Account
    {
        public string name;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Account RobA = new Account();
            RobA.name = "rob";
            Console.WriteLine(RobA.name);

            RobA = new Account();
            RobA.name = "tempjim";
            Console.WriteLine(RobA.name);

        }
    }
}
