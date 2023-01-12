using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>();

      //use a do-while loop
      int userNumber = -1;
      while (userNumber != 0)
      {
        Console.Write("Enter a number (0 to quit): ");

        string userResponse = Console.ReadLine();
        userNumber = int.Parse(userResponse);

        //add number to the list if not 0
        if (userNumber !=0)
        {
            numbers.Add(userNumber);
        }
      }

      // part 1 : Compute the sum
      int sum = 0;
      foreach (int number in numbers)
      {
        sum += number;
      } 

      Console.WriteLine($"The sum is: {sum}");
      //Part 2: Compute the average

      float average = ((float)sum) / numbers.Count;
      Console.WriteLine($"The avwrage is : {average}");

      //part 3: find the max
      //there are several ways to do this such as sorting the list

      int max = numbers[0];


      foreach (int number in numbers)
      {
        if (number > max)
        {
            //if grerster that the max, find the new max!
            max = number;
        }
      }

      Console.WriteLine($"The max is: {max}");
    }
}