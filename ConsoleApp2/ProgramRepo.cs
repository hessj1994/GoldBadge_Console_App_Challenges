using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A method to Add an object to a dictionary, A method to Delete an object from a queue, a method to check if the user typed yes or no

namespace _01_KCafeConsoleApp
{
    class ProgramRepo
    {
        List<Cafe> _attributeOne = new List<Cafe>();
        List<CafeT> _attributeTwo = new List<CafeT>();

        public void BuildMenuID()
        {
            _MenuID.Add(new KCafeClasses(1, "name", "description", "list", 5));
        }
        //public void BuildAttributeTwo()
        //{
        //    _attributeTwo.Add(new CafeT(1, ""));
        //    _attributeTwo.Add(new CafeT(1, ""));
        //}
        public List<Cafe> ReturnCafe()
        {
            return _attributeOne;
        }
        //public List<CafeT> ReturnCafeT()
        //{
        //    return _attributeTwo;
        //}
        public AttributeTwo GetAttributeTwo()
        {

        }
    }
}
