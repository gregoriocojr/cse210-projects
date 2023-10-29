using System;
using System.IO;
using System.Collections.Generic;

public class ApplicantManager
{
    private List<Applicant> _applicants = new List<Applicant>();

    public void ApplicantAction()
    {
        Console.Clear();
        Console.WriteLine("Hello, Applicant!");
        Console.WriteLine("");
        Console.WriteLine("What is your application status?\n" +
            "1. New Applicant\n" +
            "2. Returning Applicant");
        Console.Write("Select your appropriate status: ");
        string applicantAction = Console.ReadLine();
        switch (applicantAction)
        {
            case "1":
                NewApplicant();
                break;

            case "2":
                LoadApplicantByApplicationNumber();
                break;
        }
    }

    public void ListJobGroup()
    {
        Console.WriteLine("The following are the Job Groups:\n" +
            "1. Teaching\n" +
            "2. Teaching Related\n" +
            "3. Non-Teaching");
        Console.Write("Select your job group: ");
    }

    public void NewApplicant()
    {
        string name, contactNumber, cityAddress;
        double education, training, experience;

        Console.Clear();
        Console.WriteLine("Hello, New Applicant!");
        Console.WriteLine("Please provide the following details:");
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("Contact Number: ");
        contactNumber = Console.ReadLine();
        Console.Write("City Address: ");
        cityAddress = Console.ReadLine();

        Console.WriteLine("");
        ListJobGroup();
        if (int.TryParse(Console.ReadLine(), out int jobGroup) && jobGroup >= 1 && jobGroup <= 3)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select the corresponding point for Education:\n" +
                "     0 - No schooling or elementary undergraduate\n" +
                "     1 - Elementary graduate or junior high school undergraduate\n" +
                "     2 - Junior high school graduate or senior high school undergraduate\n" +
                "     3 - Senior high school graduate\n" +
                "     4 - Bachelor degree undergraduate\n" +
                "     5 - Vocational or associate degree holder\n" +
                "     6 - Bachelor degree graduate\n" +
                "     7 - Units of a master's degree\n" +
                "     8 - Master's degree graduate\n" +
                "     9 - Units of a doctoral degree\n" +
                "    10 - Doctoral degree graduate");
            Console.WriteLine("Select the corresponding point for Education (0-10): ");
            education = GetInput(0, 10);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select the corresponding point for Training:\n" +
                "     0 - Less than 8 hours of relevant training\n" +
                "     1 - At least 8 hours of relevant training\n" +
                "     2 - At least 16 hours of relevant training\n" +
                "     3 - At least 24 hours of relevant training\n" +
                "     4 - At least 32 hours of relevant training\n" +
                "     5 - At least 40 hours of relevant training\n" +
                "     6 - At least 48 hours of relevant training\n" +
                "     7 - At least 56 hours of relevant training\n" +
                "     8 - At least 64 hours of relevant training\n" +
                "     9 - At least 72 hours of relevant training\n" +
                "    10 - At least 80 hours of relevant training");
            Console.WriteLine("Select the corresponding point for Training (0-10): ");
            training = GetInput(0, 10);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select the corresponding point for Experience:\n" +
                "     0 - Less than 1 month of relevant experience\n" +
                "     1 - More than 1 month but less than 1 year of relevant experience\n" +
                "     2 - At least 2 years of relevant experience\n" +
                "     3 - At least 3 years of relevant experience\n" +
                "     4 - At least 4 years of relevant experience\n" +
                "     5 - At least 5 years of relevant experience\n" +
                "     6 - At least 6 years of relevant experience\n" +
                "     7 - At least 7 years of relevant experience\n" +
                "     8 - At least 8 years of relevant experience\n" +
                "     9 - At least 9 years of relevant experience\n" +
                "    10 - At least 10 years of relevant experience");
            Console.WriteLine("Select the corresponding point for Experience (0-10): ");
            experience = GetInput(0, 10);

            Applicant applicant = null;
            string applicationNumber = "";

            switch (jobGroup)
            {
                case 1:
                    applicant = new Teaching(name, contactNumber, cityAddress, education, training, experience, applicationNumber);
                    applicationNumber = applicant.GenerateApplicationNumber();
                    break;
                case 2:
                    applicant = new TeachingRelated(name, contactNumber, cityAddress, education, training, experience, applicationNumber);
                    applicationNumber = applicant.GenerateApplicationNumber();
                    break;
                case 3:
                    applicant = new NonTeaching(name, contactNumber, cityAddress, education, training, experience, applicationNumber);
                    applicationNumber = applicant.GenerateApplicationNumber();
                    break;
            }
            if (applicant != null)
            {
                Console.WriteLine($"Application Number: {applicationNumber}");
                double score = applicant.CalculateScore();
                Console.WriteLine($"Score: {score}");
                string applicantDetails = GetStringDetails(applicant);
                StoreApplicantInformation(applicantDetails, applicationNumber);
            }
        }
        else
        {
            Console.WriteLine("Invalid input for job group. Please select a number between 1 and 3.");
        }
    }

    public double GetScore(Applicant applicant)
    {
        double score = applicant.CalculateScore();
        return score;
    }

    public string GetStringDetails(Applicant applicant)
    {
        string details = $"{applicant.Name}, {applicant.ContactNumber}, {applicant.CityAddress}, {applicant.Education}, {applicant.Training}, {applicant.Experience}";
        return details;
    }

    public void StoreApplicantInformation(string details, string applicationNumber)
    {
        string folderPath = "ApplicantData";

        try
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, $"{applicationNumber}.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(details);
            }

            Console.WriteLine("Applicant information has been stored in the folder: " + folderPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while saving applicant information: " + ex.Message);
        }
    }

    public void LoadApplicantByApplicationNumber()
    {
        Console.Clear();
        Console.WriteLine("Load Applicant by Application Number");
        Console.Write("Enter the Application Number: ");
        string applicationNumber = Console.ReadLine();
        string folderPath = "ApplicantData";

        try
        {
            string filePath = Path.Combine(folderPath, $"{applicationNumber}.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Applicant with the provided Application Number not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while loading applicant information: " + ex.Message);
        }
    }

    private int GetInput(int min, int max)
    {
        int value;
        if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
        {
            return value;
        }
        Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
        return GetInput(min, max);
    }
}