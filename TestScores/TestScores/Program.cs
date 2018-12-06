using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputScore;
            string exitInput;
            int exit = 0;
            int average = 0;
            int score = 0;
            int total = 0;
            int tests = 0;

            while(exit != 999)
            {
                WriteLine("Enter a test score");
                inputScore = ReadLine();
                score = Convert.ToInt32(inputScore);

                if(score >= 0 && score <= 100)
                {
                    total = total + score;
                    tests = tests + 1;
                }
                else
                {
                    WriteLine("ERROR");
                }

                average = total / tests;

                WriteLine("To exit enter 999, to enter another score enter 1");
                exitInput = ReadLine();
                exit = Convert.ToInt32(exitInput);
            }

            WriteLine("Scores Entered: " + tests);
            WriteLine("Average Score: " + average);
        }
    }
}
