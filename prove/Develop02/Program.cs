using System;

class Program
{
    static void Main(string[] args)
    {
        var prompts = new List<String> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
    }


class Entry {

    public string _text;
    public string _prompt;
    public string _date;

    public void Display() {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    } 
}

class Journal {
    
    public List<Entry> _entries = new List<Entry>();

    public void Display() {

    }
}

class SaveJournal {

}

class LoadJournal {

}
}







  

