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
        public void Run()
        {
            _programRepo.BuildAttributeOne;
            _programRepo.BuildAttributeTwo;
            StartProgram();
        }
        private void StartProgram()
        {

        }
    }
}
