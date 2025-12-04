using System;

namespace calculator
{
    class calc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my calculator!");
            Console.Write("What's your name? ");

            string nameInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nameInput))
            {
                nameInput = "User";
            }

            Console.WriteLine("Hi " + nameInput + "!");

            Console.WriteLine();
            Console.WriteLine("Okay, let's add two numbers together.");

            Console.Write("Enter first number: ");
            double num1;
            double.TryParse(Console.ReadLine(), out num1);

            Console.Write("Enter second number: ");
            double num2;
            double.TryParse(Console.ReadLine(), out num2);
            double result = num1 + num2;

            Console.WriteLine();
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + result);
            Console.WriteLine();
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
