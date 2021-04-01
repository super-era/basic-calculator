using System;

namespace basic_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            TitleAndIntroduction();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the first number.");
                var number1 = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine();
                
                Console.WriteLine("Which operation would you like to perform? Please enter the representing symbol.");
                Console.WriteLine();
                Console.WriteLine("+: Addition");
                Console.WriteLine("-: Subtraction");
                Console.WriteLine("/: Division");
                Console.WriteLine("*: Multiplication");
                Console.WriteLine();

                var selectedOperation = Console.ReadLine().Trim();
                Console.WriteLine();

                Console.WriteLine("Enter the second number.");
                var number2 = double.Parse(Console.ReadLine().Trim());
                Console.WriteLine();



                switch (selectedOperation)
                {
                    case "+":
                        Addition(number1, number2);
                        break;
                    case "-":
                        Subtraction(number1, number2);
                        break;
                    case "/":
                        Division(number1, number2);
                        break;
                    case "*":
                        Multiplication(number1, number2);
                        break;
                }

                Console.WriteLine("Do you want to use the C#lcumalator again?");

                var anotherUserCalculation = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();
                
                if (anotherUserCalculation == "n" || anotherUserCalculation == "no")
                {
                    Console.WriteLine("Exiting C#lcumalator...");
                    break;
                }

            }

            
            // methods

            static void TitleAndIntroduction()
            {
                // title
                Console.WriteLine("~~C#lcumalator~~");

                // introduction
                Console.WriteLine("This program takes two numbers, performs an operation of your choice with them, and returns the answer.");
                Console.WriteLine("Press any key to begin.");
                Console.ReadKey();
                Console.WriteLine();

            }

            static void Addition(double a, double b)
            {
                Console.WriteLine($"{a} + {b} = {a + b}.");
                Console.WriteLine();
            }

            static void Subtraction(double a, double b)
            {
                Console.WriteLine($"{a} - {b} = {a - b}.");
                Console.WriteLine();
            }

            static void Division(double a, double b)
            {
                Console.WriteLine($"{a} ÷ {b} = {a / b}.");
                Console.WriteLine();
            }

            static void Multiplication(double a, double b)
            {
                Console.WriteLine($"{a} x {b} = {a * b}.");
                Console.WriteLine();
            }


                
                
        }
    }
}
