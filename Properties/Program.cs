using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            StaffMember sam = new StaffMember();
            sam.Age = 44;
            Console.WriteLine(sam.Age);
            Console.WriteLine(sam.aim);

        }
    }
}
