using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber = -1;
        int count = 0;
        string response = "yes";

        while (response == "yes")
        {
            while (guessNumber != magicNumber)
            {
                Console.WriteLine("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                count = count + 1;
                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber == magicNumber)
                {
                    Console.WriteLine($"You guessed it! It took you {count} to guess it.");
                }
            }
        Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
    }
}