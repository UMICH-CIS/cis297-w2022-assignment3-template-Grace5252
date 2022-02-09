using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// Derived class from Account that adds a fee per transaction.
    /// </summary>
    class CheckingAccount : Account
    {
        private decimal fee;

        /// <summary>
        /// Constructor that uses the base constructor for balance, and takes a fee
        /// </summary>
        /// <param name="inputBalance">takes an input from the user to make the initial balance</param>
        /// <param name="inputFee">user input for transaction fee</param>
        public CheckingAccount(decimal inputBalance, decimal inputFee) : base(inputBalance)
        {
            fee = inputFee;
        }

        /// <summary>
        /// Adds an inputted credit to an account before subtracting a fee
        /// </summary>
        /// <param name="input">user input for credit to be added</param>
        public new void Credit(decimal input)
        {
            base.Credit(input);
            Balance -= fee;
        }

        /// <summary>
        /// Subtracts an inputted debit to an account before subtracting a fee if the debit was successful.
        /// </summary>
        /// <param name="input">user input for debit to be subtracted</param>
        public new void Debit(decimal input)
        {
            if (base.Debit(input))
            {
                Balance -= fee;
            }
        }
    }
}
