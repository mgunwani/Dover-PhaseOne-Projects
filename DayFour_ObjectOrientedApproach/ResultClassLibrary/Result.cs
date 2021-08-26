using SportsClassLibrary;
using System;

namespace ResultClassLibrary
{
    public class Result : Sport
    {
        float totalMarks;
        float averageMarks;
        public void calculateResult()
        {
            this.totalMarks = this.objectiveMarks + this.subjectiveMarks + this.score;
            this.averageMarks = this.totalMarks / 3;
            Console.WriteLine("Total Marks : " + this.totalMarks);
            Console.WriteLine("Average Marks : " + this.averageMarks);
            if (this.objectiveMarks > 70 && this.subjectiveMarks > 70 && this.score > 70)
            {
                if (this.averageMarks >= 75)
                {
                    Console.WriteLine("You are shortlisted for next round.");
                }
                else
                {
                    Console.WriteLine("You are rejected. Better luck next time.");
                }
            }
            else
            {
                Console.WriteLine("You are rejected. Better luck next time.");
            }
        }
    }
}
