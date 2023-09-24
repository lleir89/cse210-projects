public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {  
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    public string GetDateTime()
    // Method to get the date and time for journal record
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        // Console.WriteLine(now.ToString("F"));
        // Displays Thursday, September 21, 2023 7:00:00 AM
        return currentDateTime;
    }
}