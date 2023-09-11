using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade? ");
        string percentage = Console.ReadLine();
        float grade = float.Parse(percentage);

        if (grade >= 90)
        {
            Console.WriteLine("Your letter grade is: A");
        }

        else if (grade >= 80)
        {
            Console.WriteLine("Your letter grade is: B");
        }

        else if (grade >= 70)
        {
            Console.WriteLine("Your letter grade is: C");
        }

        else if (grade >= 60)
        {
            Console.WriteLine("Your letter grade is: D");
        }

        else
        {
            Console.WriteLine("Your letter grade is: F");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congartulations! You passed the course!");
        }

        else
        {
            Console.WriteLine("You may fell short this semester, but you can do better next time.");
        }
    }
}