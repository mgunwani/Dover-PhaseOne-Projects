/*using System;

namespace ObjectOrientedConcepts
{

    class Person
    {
        private int id;
        private string name;

        // Default Constructor
        public Person()
        {
            this.id = 101;
            this.name = "Annonymous";
        }

        // Parameterized Constructor
        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        // Copy Contructor
        public Person(Person p)
        {
            this.id = p.id;
            this.name = p.name;
        }

        public void displayDetails()
        {
            Console.WriteLine("Person Id : {0}", id);
            Console.WriteLine("Person Name : {0}", name);
        }
    }

    class CopyConstructorExample
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.displayDetails();

            Console.WriteLine("********************");

            Person person1 = new Person(101, "Shruti");
            person1.displayDetails();

            Console.WriteLine("********************");

            Person person2 = new Person(102, "Kartik");
            person2.displayDetails();

            Console.WriteLine("********************");

            Person person3 = new Person(person);
            person3.displayDetails();

            Console.ReadKey();
        }
    }
}
*/