using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_12
{
    public class Human
    {
        private string _name;
        private int _age;

         public Human(string name, int age)
        {
            _name = name;
            _age = age;
        }
        
       public string Name
        {
            set
            {
                _name = value;
            }

            get
            {
                return _name;
            }
        }

        public int Age
        {
            set
            {
                if (value > 130 || value <=0)
                {
                    Console.WriteLine("Incorrect age");
                }
                else
                {
                    _age = value;
                }
               
            }

            get
            {
                if (_age == 0)
                    Console.WriteLine("Null");
                return _age;
            }
        }
    }
}
