using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_.Interface
{
    internal interface IAccount
    {         /*
            IAccount(interface):
- PasswordChecker() - parametr olaraq string password qəbul edir.
- ShowInfo()*/
        public bool PasswordChecker(string password);
        public void  ShowIfo();
    }
}
