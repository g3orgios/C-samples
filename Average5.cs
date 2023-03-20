using System;
using System.Linq;

class Average5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        var filteredNumbers = numbers.Where(n => n % 2 == 0 && n % 5 == 0);

        if (filteredNumbers.Any())
        {
            double average = filteredNumbers.Average();
            Console.WriteLine($"The average of the even numbers that are divisible by 5 is: {average}");
        }
        else
        {
            Console.WriteLine("There are no even numbers that are divisible by 5 in the list.");
        }
    }
}
