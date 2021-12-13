using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class PremiumAccount : Account
    {
        public int Overdraft { get; set; }
        public PremiumAccount(string firstName, string lastName, int amount, int pin,int overdraft) : base(firstName, lastName, amount, pin)
        {
            Overdraft = overdraft;
            Amount = Amount + overdraft;
        }
        public override void WithDraw(int amountToWithdraw)
        {
            //base.WithDraw(amountToWithdraw);
            if (Amount < amountToWithdraw)
            {
                Console.WriteLine("Invalid amount to withdraw, please check your overdraft and your current balance to try again.");
            }
            else
            {
                Console.WriteLine("You have successfully withdraw {0} pounds",amountToWithdraw);
                Amount = Amount - amountToWithdraw;
            }
        }
        public override void Deposit(int depositAmount)
        {
            if (depositAmount > 0)
            {

                Console.WriteLine("You have sucessfully deposit");
            }
            else
            {
                Console.WriteLine("Invalid amount to withdraw, please try again or check your account.");
            }
        }
    }
}
