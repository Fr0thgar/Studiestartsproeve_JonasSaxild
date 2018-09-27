using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studiestartsproeve_JonasSaxild
{
    class Person
    {
        public String _name;
        public int _age;
        public int _telephonenumber;

       
        public Person(String name, int age, int telephonenumber)
        {
            _name = name;

            _age = age;

            _telephonenumber = telephonenumber;
        }

        public void IncreaseAge()
        {
            _age = _age + 1;
        }  
    }
}
