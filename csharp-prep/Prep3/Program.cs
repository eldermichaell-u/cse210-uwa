using System;

class Program
{
    static void Main(string[] args)
    {

       Console.Write("What is the magic number? ");
       int magicNumber = int.Parse(Console.ReadLine());

       //For part 3, where we use a ramdom number
       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1,101);

       int guess = -1;
       
       //use do-whie loop 
       while (guess != magicNumber)
       {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");

        }
        else if  (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else (magicNumber == guess)
        {
            Console.WriteLine("You guessed it!");
        }
        {

        }
       }


    }
}