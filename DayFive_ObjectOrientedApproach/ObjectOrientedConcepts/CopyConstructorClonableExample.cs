/*using System;

namespace ObjectOrientedConcepts
{

    class Person: ICloneable
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
        // Alternatively use Clonable Interface
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void displayDetails()
        {
            Console.WriteLine("Person Id : {0}", id);
            Console.WriteLine("Person Name : {0}", name);
        }
    }

    class CopyConstructorClonableExample
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

            Person person3 = person2.Clone() as Person;
            person3.displayDetails();

            Console.ReadKey();
        }
    }
}
*/