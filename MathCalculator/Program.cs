using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Calculator");

            Console.Write("Write the fist number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose the operator (+, -, *, /): ");
            char operators = Console.ReadLine()[0];

            Console.Write("Write the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operators)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error, cannot to divide with 0.");
                    break;
                default:
                    Console.WriteLine("Not valid.");
                    break;
            }

            Console.WriteLine("Result is: " + result);
        }
    }
}
