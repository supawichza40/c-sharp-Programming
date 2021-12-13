using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApplication
{
    abstract class Budget
    {
        public int Balance { get; set; }
        public int TotalSpend { get; set; }

        public int TotalSave { get; set; }

        public Budget(int balance)
        {
            Balance = balance;
            TotalSave = balance;

        }

        public virtual void Deposit(int amountToDeposit)
        {
            if (amountToDeposit<=0)
            {
                Console.WriteLine("Invalid deposit amount!");
            }
            else
            {
                Balance = Balance + amountToDeposit;
                TotalSave = TotalSave + amountToDeposit;
            }

        }
        public void Withdraw(int amountToWithdraw)
        {
            if (amountToWithdraw> Balance)
            {
                Console.WriteLine("Invalid amount to withdraw, please try again!");
            }
            else
            {
                Balance = Balance - amountToWithdraw;
                TotalSpend = TotalSpend + amountToWithdraw;
            }
        }
        public double percentageSpent()
        {
            return TotalSpend / TotalSave;
        }
        public void TransferBetweenAccount(Budget otherAccount,int amountToTransfer)
        {
            Console.WriteLine("Transferring To other account!");
            if (amountToTransfer > Balance)
            {
                Console.WriteLine("Invalid amount to transfer, please try again.");
            }
            else
            {
                otherAccount.Deposit(amountToTransfer);
                this.Balance = this.Balance - amountToTransfer;
                TotalSave = TotalSave - amountToTransfer;
            }
        }
        public virtual void DisplayTotalSaveAndExpense()
        {
     
            Console.WriteLine("The total Save amount is £{0}",TotalSave);
            Console.WriteLine("The total Expense amount is £{0}",TotalSpend);
        }

    }
}
