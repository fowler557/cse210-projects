using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public DateTime _entryDate;


    public void DisplayEntry() 
    {
        Console.WriteLine($"{_entryDate} {_prompt} \n> {_response}\n");
    }
    
}
