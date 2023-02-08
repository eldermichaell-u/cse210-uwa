using System;

public class Resume
{
    public string _name = "";
    
    //Initiating list of new list
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //Use of the custom type "Job" in the loop
        foreach (Job job in _jobs)
        {
            //Calls the display method on each job
            job.Display();
        }
    }


}
