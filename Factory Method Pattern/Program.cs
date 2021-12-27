using System;

namespace Factory_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string CardNumber, BankCode;
            BankFactory bankFactory = new BankFactory();
            Console.WriteLine("Enter Your Card Number");

            CardNumber = Console.ReadLine();

            BankCode = CardNumber.Substring(0, 6);
            IBank bank = bankFactory.GetBank(BankCode);
            Console.WriteLine(bank.Withdrow());



        }
    }
}
