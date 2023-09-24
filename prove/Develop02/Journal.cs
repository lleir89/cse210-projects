public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("\n************** Journal Entries **************");
        foreach (Entry indexEntry in _entries)
        {
            indexEntry.Display();
        }
        Console.WriteLine("\n******************** End ********************\n");
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry indexEntry in _entries)
            {
                outputFile.WriteLine($"{indexEntry._date}; {indexEntry._promptText}; {indexEntry._entryText}");
            }
        }
        // Check the file if has been created
        if (File.Exists(file))
        {
            Console.WriteLine($"*** {file} - has been created! Your journal entries have been saved. ***\n");
        }
    }

    public void LoadFromFile(string file)
    {
        List<string> readText = File.ReadAllLines(file).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
        _entries = new List<Entry>();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                Entry anEntry = new Entry();   
                Journal entry = new Journal();

                anEntry._date = entries[0];
                anEntry._promptText = entries[1];
                anEntry._entryText = entries[2];

                _entries.Add(anEntry);
            }
    }
}