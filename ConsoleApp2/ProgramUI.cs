using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KCafeConsoleApp
{//
    class ProgramUI
    {
        private readonly ProgramRepo _programRepo = new ProgramRepo();
        public void Run()//void -> object
        {
            //_programRepo.BuildMenuID(); buildmenuid changed to AddItemToMenu
            //_programRepo.BuildAttributeTwo;
            StartProgram();
        }
        private void StartProgram()
        {

            Console.ReadLine();
        }
    }
}
