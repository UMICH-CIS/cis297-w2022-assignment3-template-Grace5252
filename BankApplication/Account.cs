using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// Base Account Class. Contains base constructor for balance, the property balance, and the base credit and debit.
    /// </summary>
    class Account
    {
        private decimal balance;

        /// <summary>
        /// Base constructor with balance
        /// </summary>
        /// <param name="inputBalance">What to set balance to</param>
        public Account(decimal inputBalance)
        {
            Balance = inputBalance;
        }

        /// <summary>
        /// Balance property with setter and getter.
        /// </summary>
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Balance)} must be >= 0.");
                }

                balance = value;
            }
        }

        /// <summary>
        /// Base credit method. Adds input to balance.
        /// </summary>
        /// <param name="input">User input added to balance.</param>
        public void Credit(decimal input)
        {
            balance += input;
        }

        /// <summary>
        /// Base debit method. Subtracts input from balance.
        /// </summary>
        /// <param name="input">The number to subtract from the balance.</param>
        /// <returns>Returns if the debit was possible or not</returns>
        public bool Debit(decimal input)
        {
            if(balance - input < 0)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }
            else
            {
                balance -= input;
                return true;
            }
        }

    }
}
