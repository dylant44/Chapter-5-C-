using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 11;
            int i = 0;
            string guessString;
            string previousHighLow = "";
            int userGuess = 0;
            int previousGuess = 0;
            bool exit = false;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            WriteLine("Guess a number between 1 and 10");

            while (exit != true)
            {
                guessString = ReadLine();
                userGuess = Convert.ToInt32(guessString);

                if (previousHighLow == "high" && userGuess > previousGuess)
                {
                    WriteLine("Hey stupid I said you were too high last time. Learn from your mistakes.");
                }
                else if(previousHighLow == "low" && userGuess < previousGuess)
                {
                    WriteLine("Hey stupid I said you were too low last time. Learn from your mistakes.");
                }

                if (userGuess > randomNumber)
                {
                    WriteLine("Too High! Guess Again.");
                    previousHighLow = "high";
                }
                else if (userGuess < randomNumber)
                {
                    WriteLine("Too Low! Guess Again.");
                    previousHighLow = "low";
                }
                else if (userGuess == randomNumber)
                {
                    exit = true;
                }

                previousGuess = userGuess;
                i = i + 1;
            }

            WriteLine("Correct! It took you " + i + " tries");

        }
    }
}
