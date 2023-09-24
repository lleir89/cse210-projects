using System;

class Program
{
    static void Main(string[] args)
    {
        int menuNumber = -1;
        Console.Write("\n**** Welcome to the Journal Program! ****\n");

        Journal theJournal = new Journal();
        PromptGenerator thePrompt = new PromptGenerator();

        while (menuNumber != 5)
        {
            Console.Write(@"Please select one of the following choices:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit
        What would you like to do? ");
            menuNumber = int.Parse(Console.ReadLine());
            if (menuNumber == 1)
            {
                // Write Journal Entry
                
                Entry anEntry = new Entry();              
                anEntry._date = anEntry.GetDateTime();
                anEntry._promptText = thePrompt.GetRandomPromt();

                Console.Write($"\n{anEntry._promptText}\n");
                Console.Write(">>> ");
                anEntry._entryText = Console.ReadLine();
                Console.Write("\n");

                theJournal._entries.Add(anEntry);
            }
            else if (menuNumber == 2)
            {
                // Display Journal Entries
                theJournal.DisplayAll();
            }
            else if (menuNumber == 3)
            {
                // Load text file
                Console.WriteLine($"\nWhat is the filename?");
                string loadFilename = Console.ReadLine();
                Console.Write("\n");
                // Check the file if already exists
                if (!File.Exists(loadFilename))
                {
                    Console.WriteLine($"*** {loadFilename} file do not exist. ***\n");
                    continue;
                }
                theJournal.LoadFromFile(loadFilename);
            }
            else if (menuNumber == 4)
            {
                // Save to text file
                Console.WriteLine($"\nWhat is the filename?");
                string saveFilename = Console.ReadLine();
                Console.Write("\n");
                // Check the file if already exists
                if (File.Exists(saveFilename))
                {
                    Console.WriteLine($"*** {saveFilename} file already exits and it's going to be overwritten. ***\n");
                }
                theJournal.SaveToFile(saveFilename);
            }
            else if (menuNumber == 5)
            {
                // Quite
                Console.WriteLine("\nThanks for using the Journal App!\n");
            }
        
        }
    }
}