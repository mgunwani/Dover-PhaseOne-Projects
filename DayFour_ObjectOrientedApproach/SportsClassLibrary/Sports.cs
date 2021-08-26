using MarksClassLibrary;
using System;

namespace SportsClassLibrary
{
    public class Sport : Marks
    {
        protected float score;
        public new void acceptDetails()
        {
            base.acceptDetails();
            Console.Write("Enter Sports Score: ");
            this.score = float.Parse(Console.ReadLine());
        }
        public new void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Sports Score : " + this.score);
        }
    }
}
