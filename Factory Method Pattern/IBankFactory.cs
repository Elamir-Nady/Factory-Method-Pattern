using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern
{
    interface IBankFactory
    {
        IBank GetBank(string BankCode);
    }
}
