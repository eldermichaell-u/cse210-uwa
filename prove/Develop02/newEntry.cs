using System;


public class newEntry

{
    public string responseBack = "";
    
    public string prompt = "";
    
    public string date = "";


    public void Display(){

    Console.WriteLine($"{date} - {prompt}");
    Console.WriteLine($"{responseBack}");
    }


}