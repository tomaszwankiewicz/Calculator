using System;

namespace Calculator
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in calculator!");

            Console.WriteLine("Please enter the first number: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            var number1 = float.Parse(Console.ReadLine()); //liczbę wpisuj z przecinkami a nie kropka
            Console.ResetColor();

            Console.WriteLine("Please enter the second number: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            var number2 = float.Parse(Console.ReadLine()); //liczbę wpisuj z przecinkami a nie kropka
            Console.ResetColor();

            Console.WriteLine("What action you want to perform? ");
            Console.ForegroundColor = ConsoleColor.Blue;
            var operation = Console.ReadLine();
            Console.ResetColor();

            switch (operation)
            {
                case "Add": //sposób pierwszy
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Addition result = new Addition();
                        result.Dodaj(number1,number2);
                        Console.ResetColor();
                    }
                    break;

                case "Subtract": //sposób drugi
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Subtraction result = new Subtraction();
                        Console.WriteLine("The result of subtraction is: " + result.Odejmij(number1, number2));
                        Console.ResetColor();
                    }
                    break;

                case "Multiply":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Multiplication result = new Multiplication();
                        result.Pomnoz(number1, number2);
                        Console.ResetColor();
                    }
                    break;

                case "Divide":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Division result = new Division();
                        result.Podziel(number1, number2);
                        Console.ResetColor();
                    }
                    break;

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid operation");
                        Console.ResetColor();
                    }
                    break;
            }
        }
    


    }


}
