using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        
        string userName = promptUserName();

        int squareNumber = squareNumber();

        DisplayResult(userName, squareNumber);

    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string promptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;

    }
    
    
    static int SquareNumber(int number)
    {
        Console.Write("Please enter your favorite number: ");
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}