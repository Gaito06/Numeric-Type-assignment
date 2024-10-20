using System;

public class Program
{
    public static void Main()
    {
        // Prompt user for the length of the rectangle
        Console.WriteLine("Please enter the length of the rectangle:");
        string lengthInput = Console.ReadLine(); // Read user input for length
        double length = Convert.ToDouble(lengthInput); // Convert input to double

        // Prompt user for the width of the rectangle
        Console.WriteLine("Please enter the width of the rectangle:");
        string widthInput = Console.ReadLine(); // Read user input for width
        double width = Convert.ToDouble(widthInput); // Convert input to double

        // Calculate the area of the rectangle
        double area = length * width;

        // Print the result to the console
        Console.WriteLine("The area of the rectangle is: " + area);
    }
}
