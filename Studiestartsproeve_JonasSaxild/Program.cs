using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studiestartsproeve_JonasSaxild
{
    class Program
    {
        static void Main(string[] args)
        {
           Person familyMember1 = new Person("Hansi", 42, 122564543);
           Person familyMember2 = new Person("Pauli", 56, 78465231);
           Person familyMember3 = new Person("Bensi", 78, 12345697);



            Console.WriteLine("Name: "+familyMember1._name);
            Console.WriteLine("Age: "+familyMember1._age);
            Console.WriteLine("TelephoneNumber: "+familyMember1._telephonenumber);
            familyMember1.IncreaseAge();
            Console.WriteLine("New Age: " + familyMember1._age);


            Console.WriteLine("Name: " + familyMember2._name);
            Console.WriteLine("Age: " + familyMember2._age);
            Console.WriteLine("TelephoneNumber: " + familyMember2._telephonenumber);
            familyMember2.IncreaseAge();
            Console.WriteLine("New Age: " + familyMember2._age);


            Console.WriteLine("Name: " + familyMember3._name);
            Console.WriteLine("Age: " + familyMember3._age);
            Console.WriteLine("TelephoneNumber: " + familyMember3._telephonenumber);
            familyMember3.IncreaseAge();
            Console.WriteLine("New Age: " + familyMember3._age);


        }
    }
}
