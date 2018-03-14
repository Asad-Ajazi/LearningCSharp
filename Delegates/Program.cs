using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //declare delegate.
    public delegate decimal CalculatorFee(decimal bal);
    class Program
    {
        static void Main(string[] args)
        {
            //instance of delegate
            CalculatorFee calc;

            calc = new CalculatorFee(rip);
            calc(-1);
            calc = new CalculatorFee(frfee);
            calc(-1);
        }
        public static decimal rip(decimal bal)
        {
            Console.WriteLine("calling rip method");
            if (bal < 0)
            {
                return 100;
            }
            else
            {
                return 1;
            }
        }
        public static decimal frfee(decimal bal)
        {
            Console.WriteLine("calling frfee method");
            if (bal < 0)
            {
                return 10;
            }
            else
            {
                return 1;
            }
        }
    }
}
