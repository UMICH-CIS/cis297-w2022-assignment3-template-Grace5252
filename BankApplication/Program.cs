using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// This program accesses different types of accounts using inheritance and polymorphism.
    /// </summary>
    /// <Student>Grace Cappella</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    class Program
    {
        /// <summary>
        /// Runs test cases for Account, SavingsAccount, and CheckingAccount
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Account a = new Account(100M);
            SavingsAccount s = new SavingsAccount(100M, .5M);
            CheckingAccount c = new CheckingAccount(100M, .5M);

            Console.WriteLine("Account Class");
            Console.WriteLine(a.Balance);
            a.Credit(100M);
            Console.WriteLine(a.Balance);
            a.Debit(100M);
            Console.WriteLine(a.Balance);
            Console.WriteLine("~~~~~~~~~~~~~~");

            Console.WriteLine("Savings Account Class");
            Console.WriteLine(s.Balance);
            s.Credit(100M);
            Console.WriteLine(s.Balance);
            s.Debit(100M);
            Console.WriteLine(s.Balance);
            s.Credit(s.CalculateInterest());
            Console.WriteLine(s.Balance);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Checking Account Class");
            Console.WriteLine(c.Balance);
            c.Credit(100M);
            Console.WriteLine(c.Balance);
            c.Debit(100M);
            Console.WriteLine(c.Balance);
            c.Debit(1000M);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");

            var accList = new List<Account>(){a, s, c};

            foreach(var currentAccount in accList)
            {
                Console.WriteLine(currentAccount);

                Console.Write("Enter an amount to deposit: ");
                decimal depositInput = decimal.Parse(Console.ReadLine());

                if(currentAccount is SavingsAccount)
                {
                    var account = (SavingsAccount)currentAccount;
                    account.Credit(depositInput);
                    account.Credit(account.CalculateInterest());
                } else if (currentAccount is CheckingAccount)
                {
                    var account = (CheckingAccount)currentAccount;
                    account.Credit(depositInput);
                }
                else
                {
                    currentAccount.Credit(depositInput);
                }

                Console.Write("Enter an amount to withdraw: ");
                decimal withdrawInput = decimal.Parse(Console.ReadLine());
                if(currentAccount is CheckingAccount)
                {
                    var account = (CheckingAccount)currentAccount;
                    account.Debit(withdrawInput);
                }
                else
                {
                    currentAccount.Debit(withdrawInput);
                }

                Console.WriteLine($"Balance: {currentAccount.Balance}");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }
    }
}
