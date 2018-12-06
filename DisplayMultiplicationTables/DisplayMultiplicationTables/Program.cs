using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DisplayMultiplicationTables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int num6 = 6;
            int num7 = 7;
            int num8 = 8;
            int num9 = 9;
            int num10 = 10;

            WriteLine("    1    2    3    4    5    6    7    8    9    10");
            WriteLine("  -------------------------------------------------->");
            WriteLine("1 | " + num1 * num1 + "    " + num1 * num2 + "    " + num1 * num3 + "    " + num1 * num4 + "    " + num1 * num5 + "    " + num1 * num6 + "    " + num1 * num7 + "    " + num1 * num8 + "    " + num1 * num9 + "    " + num1 * num10);
            WriteLine("2 | " + num2 * num1 + "    " + num2 * num2 + "    " + num2 * num3 + "    " + num2 * num4 + "    " + num2 * num5 + "   " + num2 * num6 + "   " + num2 * num7 + "   " + num2 * num8 + "   " + num2 * num9 + "   " + num2 * num10);
            WriteLine("3 | " + num3 * num1 + "    " + num3 * num2 + "    " + num3 * num3 + "    " + num3 * num4 + "   " + num3 * num5 + "   " + num3 * num6 + "   " + num3 * num7 + "   " + num3 * num8 + "   " + num3 * num9 + "   " + num3 * num10);
            WriteLine("4 | " + num4 * num1 + "    " + num4 * num2 + "    " + num4 * num3 + "   " + num4 * num4 + "   " + num4 * num5 + "   " + num4 * num6 + "   " + num4 * num7 + "   " + num4 * num8 + "   " + num4 * num9 + "   " + num4 * num10);
            WriteLine("5 | " + num5 * num1 + "    " + num5 * num2 + "   " + num5 * num3 + "   " + num5 * num4 + "   " + num5 * num5 + "   " + num5 * num6 + "   " + num5 * num7 + "   " + num5 * num8 + "   " + num5 * num9 + "   " + num5 * num10);
            WriteLine("6 | " + num6 * num1 + "    " + num6 * num2 + "   " + num6 * num3 + "   " + num6 * num4 + "   " + num6 * num5 + "   " + num6 * num6 + "   " + num6 * num7 + "   " + num6 * num8 + "   " + num6 * num9 + "   " + num6 * num10);
            WriteLine("7 | " + num7 * num1 + "    " + num7 * num2 + "   " + num7 * num3 + "   " + num7 * num4 + "   " + num7 * num5 + "   " + num7 * num6 + "   " + num7 * num7 + "   " + num7 * num8 + "   " + num7 * num9 + "   " + num7 * num10);
            WriteLine("8 | " + num8 * num1 + "    " + num8 * num2 + "   " + num8 * num3 + "   " + num8 * num4 + "   " + num8 * num5 + "   " + num8 * num6 + "   " + num8 * num7 + "   " + num8 * num8 + "   " + num8 * num9 + "   " + num8 * num10);
            WriteLine("9 | " + num9 * num1 + "    " + num9 * num2 + "   " + num9 * num3 + "   " + num9 * num4 + "   " + num9 * num5 + "   " + num9 * num6 + "   " + num9 * num7 + "   " + num9 * num8 + "   " + num9 * num9 + "   " + num9 * num10);
            WriteLine("10| " + num10 * num1 + "   " + num10 * num2 + "   " + num10 * num3 + "   " + num10 * num4 + "   " + num10 * num5 + "   " + num10 * num6 + "   " + num10 * num7 + "   " + num10 * num8 + "   " + num10 * num9 + "   " + num10 * num10);
            WriteLine("  v");
        }
    }
}
