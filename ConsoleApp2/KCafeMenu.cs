using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//cntrl + rr
namespace _01_KCafeConsoleApp
{
    public class KCafeMenu//setting up objects
    {
        public int MenuID { get; set; }
        public string MealName { get; set; }
        public string MenuDescription { get; set; }
        public string ListIngredients { get; set; }
        public double MenuPrice { get; set; }
        public KCafeMenu()
        {
        }
        public KCafeMenu(int menuID, string mealName, string menuDescription, string listIngredients, double menuPrice)
        {
            MenuID = menuID;
            MealName = mealName;
            MenuDescription = menuDescription;
            ListIngredients = listIngredients;
            MenuPrice = menuPrice;
        }
    }
}