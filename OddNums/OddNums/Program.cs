using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Odd numbers from 0 to 100");
            for(int i = 0; i < 99;)
            {
                if (i % 2 == 0)
                {
                    Write(" ");
                }
                else
                {
                    Write("" + i);
                }
                i = i + 1;
            }
        }
    }
}
