using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KCafeConsoleApp
{//streaming content, two constructors, one with content, other with. ref streaming content, empty class w/ constructors, setting properties
    public class KCafeMenu//setting up objects, cntrl rr replace all 
    {
        public int MenuID { get; set; }
        public string MealName { get; set; }
        public string MenuDescription { get; set; }
        public string ListIngredients { get; set; }//list, enum, dictionary, collection
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