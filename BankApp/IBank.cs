using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    //a container class that will be used to find accounts based on the name of the holder.

    interface IBank
    { 
        IAccount FindAccount(string name);
        bool StoreAccount(IAccount account);
    }
}
