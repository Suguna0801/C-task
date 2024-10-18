using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator in C#");

        // Input the first number
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());


        // Input the second number
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Input the operator
        Console.Write("Enter an operator (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = 0;

        // Perform the operation based on the operator
        switch (operation)
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
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                return;
        }

        // Display the result
        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
    }
}
