using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = -1;
        int sum = 0;
        int max = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (newNumber != 0)
        {
            newNumber = int.Parse(Console.ReadLine());
            numbers.Add(newNumber);
            sum = sum + newNumber;
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    
                    max = number;
                }
            }
        }
        float average = ((float)sum) / numbers.Count;
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        
    }
}