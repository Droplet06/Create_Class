using Person.person1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1;

            person1 = new Person(1, "lan", "Brooks", "Red", 30, true);

            person1.ChangeFavoriteColor();

            person1.DisplayPersonInfo();

            Person person2;

            person2 = new Person(2, "Gina", "James", "Green", 18, false);

            person2.DisplayPersonInfo();


            Person person3;
                
            person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);

            person3.FormatList();

            Person person4;

            person4 = new Person(4, "Mary", "Beals", "Yellow", 28,true);

            person4.TheAge();








         
        }
    }
}
