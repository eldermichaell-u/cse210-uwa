using System;

class Program
{
    static void Main(string[] args)
    {
        // new variable called dafaultFraction from the cs# Fraction
        Fraction defaultFraction = new Fraction();
        //Fraction is the class we are using.
        Console.WriteLine(defaultFraction.GetFractionString());

        Console.WriteLine(defaultFraction.GetDecimalValue());

        Fraction Fraction2 = new Fraction(5); 
        Console.WriteLine(Fraction2.GetFractionString());




    }
}