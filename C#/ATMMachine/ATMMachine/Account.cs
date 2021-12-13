using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class Account
    {
        private string FirstName { get; set; }
        private string LastName{ get; set; }
        protected int Amount { get; set; }
        private int Pin { get; set; }

        public Account(string firstName,string lastName,int amount,int pin)
        {
            FirstName = firstName;
            LastName = lastName;
            Amount = amount;
            Pin = pin;
        }

        public virtual void WithDraw(int amountToWithdraw)
        {
            if(amountToWithdraw> Amount)
            {
                Console.WriteLine("Invalid Amount to withdraw, please check your account and try again!");
            }
            else
            {
                Amount = Amount - amountToWithdraw;
                Console.WriteLine("You are successfully withdraw {0} pounds",amountToWithdraw);

            }
        }
        public virtual void Deposit(int depositAmount)
        {
            if (depositAmount<=0)
            {
                Console.WriteLine("Invalid amount to deposit, please try again!");
            }
            else
            {
                Amount = Amount + depositAmount;
                Console.WriteLine("You have successfully deposited {0} pounds into your account",depositAmount);

            }
        }
        public void CheckBalance()
        {
            Console.WriteLine("You have {0} pounds in your bank account",Amount);
        }
    }
}
