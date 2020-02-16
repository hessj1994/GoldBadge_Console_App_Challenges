using System;
using _01_KCafeConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_KCafeConsoleApp_Tests
{//
    [TestClass]
    public class KCafeAppChallengeOne
    {
        [TestMethod]
        public void AddItemToMenu_CheckCorrectBoolean()
        {//arrange, act, assert
            ProgramRepo repoContent = new ProgramRepo();//in streaming content tests, repo
            //creating content
            KCafeMenu mealTests = new KCafeMenu(1, "Name", "Description", "ListIngredients", 5);
            //creating meal, adding KCafeMenu params
            //type(class) meal is an object of ttype kcafemenu
            // ^^ Arranged ^^
            repoContent.CheckAddItemToMenu(mealTests);//can make additemtomenu method a bool to assert if true
            //checking if new var repoContent from ProgramRepo is adding meal to list KCakfeMenu

            bool checkResult = repoContent.CheckAddItemToMenu(mealTests);
            //^^ Act ^^

            Assert.IsTrue(checkResult);

        }
    }
}
