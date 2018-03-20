using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_12
{
    class Human2
    {
        private string _name;
     
        public string Name
        {
            set
            {
                _name = value;
            }
            
        }
        public int GetNmberOfLetters
        {

            get
            {
                
                return _name.Length;
            }
        }

    }
}
