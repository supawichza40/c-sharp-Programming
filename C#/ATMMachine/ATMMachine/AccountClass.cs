using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    abstract class AccountClass
    {
        public int Balance { get; set; }
        public virtual void GetBalance()
        {
            Console.WriteLine("The balance is {0}",Balance);
        }
        public AccountClass(int balance)
        {
            Balance = balance;
        }
    }
}
