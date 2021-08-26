using System;

namespace StudentClassLibrary
{
    public class Student
    {
        int id;
        string name;
        int age;
        public void acceptDetails()
        {
            Console.Write("Enter Student ID: ");
            this.id = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            this.name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            this.age = int.Parse(Console.ReadLine());
        }
        public void displayDetails()
        {
            Console.WriteLine("Student Id : " + this.id);
            Console.WriteLine("Student Name : " + this.name);
            Console.WriteLine("Student Age : " + this.age);
        }
    }
}
