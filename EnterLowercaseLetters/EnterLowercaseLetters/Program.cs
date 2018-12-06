using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnterLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letterInput = null;
            char letter = '\0';
            while (letter != '!')
            {
                WriteLine("Enter a lowercase letter");
                letterInput = ReadLine();
                letter = Convert.ToChar(letterInput);
                if (letter >= 'a' && letter <= 'z')
                {
                    WriteLine("OK");
                }
                else
                {
                    WriteLine("ERROR");
                }
            }
        }
    }
}
