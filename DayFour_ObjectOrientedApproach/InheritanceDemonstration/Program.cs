using ResultClassLibrary;
using System;

namespace InheritanceDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Result obj = new Result();
            obj.acceptDetails();
            Console.WriteLine("***********");
            obj.displayDetails();
            Console.WriteLine("***********");
            obj.calculateResult();
            Console.ReadKey();
        }
    }
}
