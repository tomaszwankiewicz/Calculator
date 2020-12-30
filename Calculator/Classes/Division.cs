using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Division
    {
        //metoda
        public void Podziel (float a, float b)
        {
            if (b != 0)
            {
                Console.WriteLine("The result of division is: :" + (a / b));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Cannot be divided by zero");
            }
            
        }
    }
}
