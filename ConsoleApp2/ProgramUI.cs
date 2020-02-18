using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KCafeConsoleApp
{
    class ProgramUI
    {
        private readonly ProgramRepo _programRepo = new ProgramRepo();
        public void Run()
        {
            //_kMenu.AddItemToMenu();
            //_programRepo.BuildMenuID(); buildmenuid changed to AddItemToMenu
            StartProgram();
        }
        private void StartProgram()
        {
            Console.ReadLine();
        }
    }
}
