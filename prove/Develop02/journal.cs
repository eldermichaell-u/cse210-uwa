using System;


public class Journal
{
public List<newEntry> dailyResponse = new List<newEntry>();

    public void JournalEntry()
    {
        PromptList promptList = new PromptList();
        string prompt = promptList.RandomGen();
        Console.WriteLine(prompt);

        string response = Console.ReadLine();
    
     DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
    
        newEntry _newEntry = new newEntry();
        _newEntry.date = dateText;
        _newEntry.responseBack = response;
        _newEntry.prompt = prompt;
        dailyResponse.Add(_newEntry);
    }
    public void DisplayJournal()
    {
        foreach(newEntry entry in dailyResponse)
        {
            entry.Display();
        }
        
    }

}
