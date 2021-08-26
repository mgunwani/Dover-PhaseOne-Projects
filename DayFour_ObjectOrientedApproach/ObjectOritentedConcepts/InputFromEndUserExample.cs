/*using System;

namespace ObjectOritentedConcepts
{

    class Student
    {
        // Data Members
        int id;
        string name;
        int age;

        // Member Functions

        void acceptDetails()
        {
            Console.Write("Enter Student ID: ");
            this.id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            this.name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            this.age = int.Parse(Console.ReadLine());
            
        }

        void displayDetails()
        {
            Console.WriteLine("Student Id : " + this.id);
            Console.WriteLine("Student Name : " + this.name);
            Console.WriteLine("Student Age : " + this.age);
        }
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.acceptDetails();
            student1.displayDetails();

            Console.WriteLine("*************************");

            Student student2 = new Student();
            student2.acceptDetails();
            student2.displayDetails();

            Console.ReadKey();
        }
    }


}
*/