using System;

class Program
{
    static void Main(string[] args)
    {
      Job job1 = new Job();
      job1._jobTitle = "Software Engineer";
      job1._company = "Microsoft";
      job1._startYear = 2019;
      job1._endYear = 2022;

      public void Display()
      {
        Comsole.WriteLine($"{}")
      }

      Job job2 = new Job();
      job2._jobTitle = "Mananger";
      job2._company = "Apple";
      job2._startYear = 2022;
      job2._endYear = 2023;

      public void Display()
      {
        Console.WriteLine(${})
      }


      Resume myResume = new Resume();
      myResume._name = "Michael Uwaila";

      myResume._jobs.Add(job1);
      myResume._jobs.Add("jobs2");

      myResume.Display(); 

    }
}