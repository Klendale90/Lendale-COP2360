using System;

Console.WriteLine("Enter the first number:");
string input1 = Console.ReadLine();

Console.WriteLine("Enter the second number:");
string input2 = Console.ReadLine();

try
{
    int number1 = Convert.ToInt32(null);
    int number2 = Convert.ToInt32(input2);

    int result = Divide(number1, number2);
    Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
}
catch (FormatException ex)
{
    Console.WriteLine("Error: One or both of the inputs are not valid integers.");
    Console.WriteLine($"Detailed error message: {ex.Message}");
}
catch (OverflowException)
{
    Console.WriteLine("Error: One or both of the numbers are too large or too small for an int.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Division by zero is not allowed.");
    Console.WriteLine($"Detailed error message: {ex.Message}");
}
catch (ArgumentNullException)
{
    Console.WriteLine("Error: A required value was missing.");
}
catch (ArgumentException)
{
    Console.WriteLine("Error: An argument provided to a method was invalid.");
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred.");
    Console.WriteLine($"Detailed error message: {ex.Message}");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();

int Divide(int a, int b)
{
    return a / b;
}
    {
        return a / b;
    }
}
