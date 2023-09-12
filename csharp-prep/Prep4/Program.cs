using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int givenNumber;
        do
        {
            Console.Write("Enter number: ");
            givenNumber = int.Parse(Console.ReadLine());
            if (givenNumber != 0)
            {
                numbers.Add(givenNumber);
            }
        } while (givenNumber != 0);

        int sum = numbers.Sum();
        double average = numbers.Average();
        int largest = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}