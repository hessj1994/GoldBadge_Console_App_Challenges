﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A method to Add an object to a dictionary, A method to Delete an object from a queue, a method to check if the user typed yes or no

namespace _01_KCafeConsoleApp
{
    public class ProgramRepo
    {
        List<KCafeMenu> _kMenu = new List<KCafeMenu>();//<of> KCafeMenu

        public void AddItemToMenu()
        {
            _kMenu.Add(new KCafeMenu(1, "mealName1", "menuDescription1", "listIngredients1", 2.99));
            _kMenu.Add(new KCafeMenu(2, "mealName2", "menuDescription2", "listIngredients2", 2.99));
            _kMenu.Add(new KCafeMenu(3, "mealName3", "menuDescription3", "listIngredients3", 2.99));
            _kMenu.Add(new KCafeMenu(4, "mealName4", "menuDescription4", "listIngredients4", 2.99));
            _kMenu.Add(new KCafeMenu(5, "mealName5", "menuDescription5", "listIngredients5", 2.99));
        }

        public List<KCafeMenu> ReturnBuildMenu()
        {
            return _kMenu;
        }

        public bool CheckAddItemToMenu(KCafeMenu meal)//object kcafe menu called meal, adding it to list through buildmenuid, meal is type kcafemenu
        {
            int kMenuLength = _kMenu.Count();
            _kMenu.Add(meal);
            bool wasAddedToMenu = kMenuLength + 1 == _kMenu.Count();
            return wasAddedToMenu;
        }
        //public List<KCafeMenu> ReturnCafe()
        //{
        //    return _kMenu;
        //}
    }
}
