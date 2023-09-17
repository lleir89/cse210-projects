using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int gradePercentage = int.Parse(answer);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
        }

        int lastDigitGrade = gradePercentage % 10;
        
        string additionalGrade = "";

        if (lastDigitGrade >= 7)
        {
            if (gradePercentage < 90)
            {
                additionalGrade = "+";
            }
        }
        else if (lastDigitGrade < 3)
        {
            if (gradePercentage > 60)
            {
                additionalGrade = "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}{additionalGrade}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else
        {
            Console.WriteLine("Keep trying hard, better luck next time!");
        }
    }
}