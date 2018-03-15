using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class ArrayBank
    {
        private IAccount[] accounts;

        public ArrayBank(int bankSize)
        {
            accounts = new IAccount[bankSize];
        }
    }
}
