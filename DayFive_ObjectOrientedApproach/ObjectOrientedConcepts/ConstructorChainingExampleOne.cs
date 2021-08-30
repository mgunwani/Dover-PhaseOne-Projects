/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedConcepts
{

    class Employee
    {
        private string name;
        private string email;
        private string address;

        public Employee(string name, string email, string address): this(name, address)
        {
            Console.WriteLine("Constructor with 3 Parameters");
            // this.name = name;
            // this.email = email;
            this.address = address;
        }

        public Employee(string name, string email): this(name)
        {
            Console.WriteLine("Constructor with 2 Parameters");
            this.name = name;
            this.email = email;
        }

        public Employee(string name)
        {
            Console.WriteLine("Constructor with 1 Parameters");
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("Name : {0}, Email : {1}, Address : {2}", 
                this.name, this.email, this.address);
        }

    }

    class ConstructorChainingExampleOne
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("King", "k@gmail.com", "New York");
            employee.display();
            Console.ReadKey();
        }
    }
}
*/