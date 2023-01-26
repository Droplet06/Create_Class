using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class
{
    internal class Person
    {
        private int personId;
        public string firstName;
        public string lastName;
        private string favoriteColor;
        private int age;
        private bool isWorking;

        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            this.age = age;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            string firstName = this.firstName;
            string lastName = this.lastName;
          

       

            Console.WriteLine(personId + ":" + firstName + " " + lastName + 
                "Brooks's favorite color is: " + favoriteColor);
        }

        public void ChangeFavoriteColor()
        {
            this.favoriteColor = "white";
        }

        public int GetAgeInTenYears() 
        {
            return this.age + 10;

           

        }

        public void TheAge()
        {
            Console.WriteLine(firstName + " " + lastName + "'s Age in 10 years is: " + GetAgeInTenYears());
        }

        public void FormatList()
        {
            Console.WriteLine("PersonID: " + personId
                + "\nFirstName: " + firstName
                + "\nLastName: " + lastName
                + "\nFavoriteColor: " + favoriteColor
                + "\nAge: " + age
                + "\nIsWorking: " + isWorking);
        }
    }
}
