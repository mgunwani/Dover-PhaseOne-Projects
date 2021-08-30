using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedConcepts
{

    class Person
    {
        public int id;
        public string name;

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void displayDetails()
        {
            Console.WriteLine("Person Id : {0}", id);
            Console.WriteLine("Person Name : {0}", name);
        }
    }

    class Employee : Person
    {
        public double salary;
        public string designation;
        public Employee(int id, string name, double salary, string designation): base(id, name)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public new void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Employee Salary : {0}", salary);
            Console.WriteLine("Employee Designation : {0}", designation);
        }
    }

    class ConstructorChainingExampleTwo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101, "Gautam", 1234.56d, "Manager");
            emp.displayDetails();
            Console.ReadKey();
        }
    }
}
