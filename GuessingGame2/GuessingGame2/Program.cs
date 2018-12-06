using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 11;
            int i = 0;
            string guessString;
            int userGuess;
            bool guess = false;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            WriteLine("Guess a number between 1 and 10");

             while(guess != true)
             {
                 guessString = ReadLine();
                 userGuess = Convert.ToInt32(guessString);
          
                 if(userGuess > randomNumber)
                 {
                     WriteLine("Too High! Guess Again.");
                 }
                 else if(userGuess < randomNumber)
                 {
                     WriteLine("Too Low! Guess Again.");
                 }
                 else if(userGuess == randomNumber)
                 {
                     guess = true;
                 }

                i = i + 1;
             }

            WriteLine("Correct! It took you " + i + " tries");
            
        }
    }
}
