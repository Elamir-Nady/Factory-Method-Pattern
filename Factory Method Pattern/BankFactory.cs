using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_Pattern
{
    class BankFactory : IBankFactory
    {
        public IBank GetBank(string BankCode)
        {
            switch (BankCode)
            {
                case "123456": return new BankA(); 
                case "123123": return new BankB(); 


            }
            return null;
        }
    }
}
