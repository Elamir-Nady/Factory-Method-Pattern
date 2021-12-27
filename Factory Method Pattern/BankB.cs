using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern
{
    class BankB : IBank
    {
        public string Withdrow()
        {
            return "Your Request IS Handling By BankB";
        }
    }
}
