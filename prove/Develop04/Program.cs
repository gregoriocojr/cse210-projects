using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }

            else if (choice == "2")
            {
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }

            else if (choice == "3")
            {
                Console.Clear();
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }

            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Thank you for taking the Mindfulness Activities.");
                Console.WriteLine("");
                Console.WriteLine("See you again next time. Good bye!");
                Console.WriteLine("");
                break;
            }
            else
            {
                // Added an error handling so that the choices will be only from 1 to 4.
                Console.WriteLine("Invalid input. Please enter a valid choice (1, 2, 3, or 4).");
            }
        } while (true);
    } 
}