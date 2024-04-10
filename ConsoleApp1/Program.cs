using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("0 - Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 0) { Console.WriteLine("Program terminated.");
                break;
                
            } 
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            switch (choice) {
                case 1: result = Add(num1, num2);
                Console.WriteLine("Result: " + result);
                break;
                case 2: result = Subtract(num1, num2);
                    Console.WriteLine("Result: " + result);
                    break;
                case 3: result = Multiply(num1, num2);
                    Console.WriteLine("Result: " + result);
                    break;
                case 4: result = Divide(num1, num2);
                    if (double.IsInfinity(result))
                    {
                        Console.WriteLine("Error: Division by zero.");
                        
                    }
                    else
                    {
                        Console.WriteLine("Result: " + result);
                        
                    } break;
                default: Console.WriteLine("Error: Invalid operation choice.");
                    break;
                
            }
        }
    } static double Add(double a, double b) { return a + b; } 
    static double Subtract(double a, double b) { return a - b; }
    static double Multiply(double a, double b) { return a * b; }
    static double Divide(double a, double b) { if (b == 0) { return double.PositiveInfinity; } return a / b; }
}