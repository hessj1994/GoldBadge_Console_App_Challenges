using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KCafeConsoleApp
{//
    public class KCafeClasses
    {
        public int MenuID { get; set; }
        public string MealName { get; set; }
        public string MenuDescription { get; set; }
        public string ListIngredients { get; set; }//list, enum, dictionary, collection
        public double MenuPrice { get; set; }
        public KCafeClasses()
        {
        }
        public KCafeClasses(int MenuID, string MealName, string MenuDescription, string ListIngredients, double MenuPrice)
        {
            MenuID = menuID;
            MealName = mealName;
            MenuDescription = menuDescription;
            ListIngredients = listIngredients;
            MenuPrice = menuPrice;
        }
    }
    //public class KCafeClassesTwo
    //{
    //    public int One { get; set; }
    //    public int Two { get; set; }
    //    public KCafeClassesTwo()
    //    {
    //    }
    //    public KCafeClasses(int One, string Two)
    //    {
    //        One = one;
    //        Two = two;
    //    }
    }
}
