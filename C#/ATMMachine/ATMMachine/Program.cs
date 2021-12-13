using System;

namespace ATMMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            //Account supaAccount = new Account("Supavich", "Aussawa", 1000000, 240797);
            //supaAccount.CheckBalance();
            //supaAccount.Deposit(1000000);
            //supaAccount.WithDraw(10);
            //supaAccount.CheckBalance();

            //PremiumAccount supaKingAccount = new PremiumAccount("Supavich", "Aussawa", 1000000, 240797,1000000);
            //supaKingAccount.CheckBalance();
            //supaKingAccount.WithDraw(1000);
            //supaKingAccount.CheckBalance();
            //supaKingAccount.WithDraw(1800000);
            //supaKingAccount.CheckBalance();
            //supaKingAccount.WithDraw(200000);

            //AccountClass emilyAccount = new AccountClass(1000);
            //Cannot create an instance of an abstract class.


            //Using class inherit from abstract class

            SavingAccount angelaAccount = new SavingAccount("Angela", "Buranasiri", 500);
            angelaAccount.GetBalance();

        }
    }
}
