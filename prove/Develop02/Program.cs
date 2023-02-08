using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu options");
        string menuChoice = "";

        while( menuChoice !="5")
        {
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.WriteLine("Today, what would you like to do next? ");

        menuChoice = Console.ReadLine();
        Journal _journal = new Journal();
    
        if (menuChoice == "1"){
           _journal.JournalEntry();

        }
        else if(menuChoice == "2"){
            _journal.DisplayJournal();
        }
        else if(menuChoice == "3"){

        }
        else if(menuChoice =="4"){

        }

        }
    }
}