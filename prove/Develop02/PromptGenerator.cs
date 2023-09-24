public class PromptGenerator
{
    public List<string> _prompts = new List<string>(_prompt);

    public static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "List the places I have been to today.",
        "What was the best idea you had today?",
        "List the 3 things you are grateful for today and why.",
        "What was the most outrageous thing you did today?",
        "What was the best meal of the day today and what was it?",
        "Who made you feel good today?"
    };
    public string GetRandomPromt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        string journalPrompt = _prompts[index];

        return journalPrompt;
    }
}