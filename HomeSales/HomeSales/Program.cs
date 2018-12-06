using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string initial = null;
            string inputAmount = null;
            string highest = null;
            int amount = 0;
            int Dtotal = 0;
            int Etotal = 0;
            int Ftotal = 0;
            int Total = 0;

            while(initial != "Z")
            {
                WriteLine("Enter initial of salesperson: D, E, or F. Enter Z to exit.");
                initial = ReadLine();
                
                if(initial == "D")
                {
                    WriteLine("Enter the amount of the sale");
                    inputAmount = ReadLine();
                    amount = Convert.ToInt32(inputAmount);
                    Dtotal = Dtotal + amount;
                }
                else if (initial == "E")
                {
                    WriteLine("Enter the amount of the sale");
                    inputAmount = ReadLine();
                    amount = Convert.ToInt32(inputAmount);
                    Etotal = Etotal + amount;
                }
                else if (initial == "F")
                {
                    WriteLine("Enter the amount of the sale");
                    inputAmount = ReadLine();
                    amount = Convert.ToInt32(inputAmount);
                    Ftotal = Ftotal + amount;
                }
                else if(initial == "Z")
                {
                    initial = "Z";
                }
                else
                {
                    WriteLine("ERROR Invalid Initial");
                }
                
            }

            Total = Dtotal + Etotal + Ftotal;

            if (Dtotal > Ftotal && Dtotal > Etotal)
            {
                highest = "D";
            }
            else if (Etotal > Ftotal && Etotal > Dtotal)
            {
                highest = "E";
            }
            else if (Ftotal > Dtotal && Ftotal > Etotal)
            {
                highest = "F";
            }
            WriteLine("Salesperson D's Total: " + Dtotal);
            WriteLine("Salesperson E's Total: " + Etotal);
            WriteLine("Salesperson F's Total: " + Ftotal);
            WriteLine("Grand Total: " + Total);
            WriteLine("Salesperson With Highest Total: " + highest);

        }
    }
}
