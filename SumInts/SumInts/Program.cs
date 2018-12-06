using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            int exit = 0;
            string inputString;
            string exitString;

            while (exit != 999)
            {
                WriteLine("Enter a number");
                inputString = ReadLine();
                num = Convert.ToInt32(inputString);
                sum += num;
                exit = exit + 1;
                WriteLine("Sum is " + sum);
                WriteLine("To exit enter 999, to enter another number enter 1");
                exitString = ReadLine();
                exit = Convert.ToInt32(exitString);
            }
        }
    }
}
