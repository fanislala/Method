using System;

// Define a class
class MathOperations
{
    // Define a void method that takes two integers as parameters
    public void PerformMathOperation(int num1, int num2)
    {
        // Perform a math operation on the first integer (for example, doubling it)
        int result = num1 * 2;

        // Display the second integer to the screen
        Console.WriteLine($"The result of the math operation on {num1} is: {result}, and the second integer is: {num2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        MathOperations mathOperations = new MathOperations();

        // Call the method in the class, passing in two numbers
        mathOperations.PerformMathOperation(5, 10);

        // Call the method in the class, specifying the parameters by name
        mathOperations.PerformMathOperation(num1: 8, num2: 15);
    }
}