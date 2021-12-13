using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApplication
{
    class ClothBudget:Budget
    {
        public string CategoryType { get; set; }
        public ClothBudget(int balance, string categoryType) : base(balance)
        {
            CategoryType = categoryType;
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
