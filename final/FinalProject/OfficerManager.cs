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

    public void DoTask()
    {
        string name, employeeNumber;
        bool isApprove, isQualified;

        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter your employee number: ");
        employeeNumber = Console.ReadLine();

        Console.WriteLine("Are you approving applications? (true/false): ");
        if (!bool.TryParse(Console.ReadLine(), out isApprove))
        {
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            return;
        }

        Console.WriteLine("Are you qualified for HR tasks? (true/false): ");
        if (!bool.TryParse(Console.ReadLine(), out isQualified))
        {
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
            return;
        }

        HeadOfOffice headOfOffice = new HeadOfOffice(name, employeeNumber, isApprove);
        HumanResource humanResource = new HumanResource(name, employeeNumber, isQualified);

        OfficerOption();
        if (int.TryParse(Console.ReadLine(), out int officerChoice) && officerChoice >= 1 && officerChoice <= 3)
        {
            switch (officerChoice)
            {
                case 1:
                    ViewApplications();
                    break;
                case 2:
                    if (officerChoice == 1)
                    {
                        headOfOffice.PerformTask();
                    }
                    else if (officerChoice == 2)
                    {
                        humanResource.PerformTask();
                    }
                    break;
            }
        }
    }

    public void ViewApplications()
    {
        Console.Clear();
        Console.WriteLine("View Applications");
        string folderPath = "ApplicantData";

        try
        {
            if (Directory.Exists(folderPath))
            {
                string[] filePaths = Directory.GetFiles(folderPath, "*.txt");

                if (filePaths.Length > 0)
                {
                    Console.WriteLine("List of Applicant Details:");
                    foreach (string filePath in filePaths)
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        Console.WriteLine("---------------------------------------------------");
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("---------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("No applicant details found.");
                }
            }
            else
            {
                Console.WriteLine("Applicant data folder not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while viewing applicant details: " + ex.Message);
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

}