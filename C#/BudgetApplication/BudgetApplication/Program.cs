using System;

namespace BudgetApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodBudget supavichFood = new FoodBudget(1000, "Food");
            supavichFood.DisplayTotalSaveAndExpense();
            ClothBudget supavichCloth = new ClothBudget(1000, "Cloth");
            supavichCloth.DisplayTotalSaveAndExpense();
            supavichCloth.TransferBetweenAccount(supavichFood, 500);

            supavichFood.DisplayTotalSaveAndExpense();
            supavichCloth.DisplayTotalSaveAndExpense();

        }
    }
}
