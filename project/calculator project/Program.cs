using System;

class Calculator
{
    static void Main()
    {
        bool keepRunning = true;

        do
        {
             
            Console.WriteLine("\n===== SIMPLE CALCULATOR =====");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            Console.Write("Choose an option (1-4): ");


            string choiceInput = Console.ReadLine();
            int choice;


            if (!int.TryParse(choiceInput, out choice))
            {
                Console.WriteLine("Please enter a valid number between 1 and 4.");
                continue;
            }

          
            Console.Write("Enter first number: ");
            double num1 = GetValidNumber();

            Console.Write("Enter second number: ");
            double num2 = GetValidNumber();

            double result = 0;
            bool validOperation = true;


            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} × {num2} = {result}");
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed!");
                        validOperation = false;
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} ÷ {num2} = {result}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option! Please choose 1-4.");
                    validOperation = false;
                    break;
            }
 
            if (validOperation)
            {
                Console.Write("\nDo you want to perform another calculation? (y/n): ");
                string again = Console.ReadLine().Trim().ToLower();

                if (again != "y")
                {
                    keepRunning = false;
                    Console.WriteLine("Thank you for using the calculator!");
                }
            }

        } while (keepRunning);
    }

    static double GetValidNumber()
    {
        double number;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out number))
                return number;
            else
                Console.Write("Invalid input! Please enter a valid number: ");
        }
    }
}