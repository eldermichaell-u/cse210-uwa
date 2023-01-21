using System;

class Program
{
    public static void Main()
    {
        DisplayWelcomeMessage();

        string userName = promptUserName();

        int squareNumber = promptUserNumber();

        DisplayResult(userName, SquareNumber(squareNumber));

    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static int promptUserNumber()
    {
        Console.Write("Please enter your squareNumber: ");

        int squareNumber = Convert.ToInt32(Console.ReadLine());

        return squareNumber;
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