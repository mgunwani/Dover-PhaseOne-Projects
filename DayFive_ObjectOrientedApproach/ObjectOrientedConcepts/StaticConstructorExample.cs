/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedConcepts
{
    class Person
    {
        private int id;
        private string name;
        public static string country;

        // Default Constructor
        public Person()
        {
            this.id = 101;
            this.name = "Annonymous";
        }
        static Person()
        {
            country = "India";
        }
        public void displayDetails()
        {
            Console.WriteLine("Person Id : {0}", this.id);
            Console.WriteLine("Person Name : {0}", this.name);
            Console.WriteLine("Current Country : {0}", Person.country);
        }
    }


    class PrivateConstructorExample
    {
        static void Main(string[] args)
        {
            Person.country = "Singapore";

            Person person1 = new Person();
            person1.displayDetails();

            Person person2 = new Person();
            person2.displayDetails();

            Console.ReadKey();
        }
         
    }
}
*/