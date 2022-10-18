using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        // test
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error

            // Use a switch statement to do the math.
            switch (op)
            {
                case "1":
                    result = num1 + num2;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "2":
                    result = num1 - num2;
                    break;
                case "3":
                    result = num1 * num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "4":
                    result = num1 / num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string [] args)
        {
            bool endApp = false;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine("------------------------");

            while (!endApp)
            {
                // Declare variables and set to empty.
                string NumInput1 = "";
                string NumInput2 = "";
                double result = 0;

                // Ask the user to type the first number
                Console.Write("Inpit the 1st number: ");
                NumInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while(!double.TryParse(NumInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter a number: ");
                    NumInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number
                Console.Write("Inpit the 2nd number: ");
                NumInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(NumInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter a number: ");
                    NumInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an option from the following list: ");
                Console.WriteLine("\t  1) + (sum)");
                Console.WriteLine("\t  2) - (deduct)");
                Console.WriteLine("\t  3) * (multiply)");
                Console.WriteLine("\t  4) / (devide)");
                Console.Write("Option: ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a math error.\n");
                    }
                    else Console.WriteLine("Result: " + result);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
                Console.WriteLine("-----------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'e' and Enter to close the app, or press any other key to continue: ");
                if (Console.ReadLine() == "e") endApp = true;
            }
            return;
        }
    }
}


   /* class Program
    {
        static void Main(string [] args)
        {
            // Declare variables and then initialize to zero.
            float num1, num2;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#");
            Console.WriteLine("-------------------------\n");

            // Ask the user to type the first number.
            Console.Write("Input a 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the 2nd number.
            Console.Write("Input a 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list: ");
            Console.WriteLine("\t  1) + (sum)"); 
            Console.WriteLine("\t  2) - (deduct)");
            Console.WriteLine("\t  3) * (multiply)");
            Console.WriteLine("\t  4) / (devide)");
            Console.Write("Option: ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine($"Result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine($"Result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "4":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();

        }
    } */
