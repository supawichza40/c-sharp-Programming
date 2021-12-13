using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class SavingAccount : AccountClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public SavingAccount(string firstName,string lastName,int balance) : base(balance)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override void GetBalance()
        {
            base.GetBalance();
        }
    }
}
