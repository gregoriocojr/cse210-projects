using System;
using System.Collections.Generic;
using System.IO;

public class OfficerManager
{
    public void OfficerAction()
    {
        string officerAction = "";

        Console.Clear();
        Console.WriteLine("Hello, Officer!");
        Console.WriteLine("");
        Console.WriteLine("What is your position\n" +
            "1. Head of Office\n" +
            "2. Human Resource");
        Console.Write("Select your position: ");
        officerAction = Console.ReadLine();
    }

    public void OfficerOption()
    {
        string officerChoice = "";

        Console.WriteLine("What do you want to do?\n" +
            "1. View applications\n" +
            "2. Perform assigned task\n" +
            "3. Quit");
        Console.Write("Please enter your choice: ");
        officerChoice = Console.ReadLine();
    }
}