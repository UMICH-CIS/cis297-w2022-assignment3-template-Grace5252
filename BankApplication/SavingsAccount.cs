using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// Derived class from Account. Adds an interest rate.
    /// </summary>
    class SavingsAccount : Account
    {
        private decimal interestRate;

        /// <summary>
        /// Constructor for Savings Account. Takes the input balance from base constructor, and the input rate.
        /// </summary>
        /// <param name="inputBalance">Enters the inital balance from user</param>
        /// <param name="inputRate">Enters the input rate from user</param>
        public SavingsAccount(decimal inputBalance, decimal inputRate) : base(inputBalance)
        {
            interestRate = inputRate;
        }

        /// <summary>
        /// Calcuates how much interest is grown from the balance.
        /// </summary>
        /// <returns>added credit from interest</returns>
        public decimal CalculateInterest()
        {
            return interestRate * Balance;
        }
    }
}
