using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApplication
{
    class FoodBudget : Budget
    {
        public string CategoryType { get; set; }
        public FoodBudget(int balance,string typeOfBudget) : base(balance)
        {
            CategoryType = typeOfBudget;
        }
        public string getTypeOfCategory()
        {
            return CategoryType;
        }
        public override void DisplayTotalSaveAndExpense()
        {
            Console.WriteLine("--------{0}--------", CategoryType);
            base.DisplayTotalSaveAndExpense();

        }

    }
}
