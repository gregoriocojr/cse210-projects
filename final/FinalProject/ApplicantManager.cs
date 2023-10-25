using System;
using System.Collections.Generic;
using System.IO;

public class ApplicantManager
{
    private List<Applicant> _applicants;
    // private int _applicationCounterForTP = 1;
    // private int _applicationCounterForTRP = 1;
    // private int _applicationCounterForNTP = 1;

    public void ApplicantAction()
    {
        string applicantAction = "";

        Console.Clear();
        Console.WriteLine("Hello, Applicant!");
        Console.WriteLine("");
        Console.WriteLine("What is your application status?\n" +
            "1. New Applicant\n" +
            "2. Returning Applicant");
        Console.Write("Select your appropriate status: ");
        applicantAction = Console.ReadLine();
        switch (applicantAction)
        {
            case "1":
                NewApplicant();
                break;
            
            case "2":
                Console.WriteLine("codes for returning coming up...");
                break;
        }
    }

    public void ListPositionTypes()
    {
        Console.WriteLine("Select position type:\n" +
            "1. Teaching\n" +
            "2. Teaching Related\n" +
            "3. Non-Teaching");
    }

    public void NewApplicant()
    {
        string name, contactNumber, cityAddress;
        int education, training, experience;

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
        Console.WriteLine("Select position type:\n" +
            "1. Teaching\n" +
            "2. Teaching Related\n" +
            "3. Non-Teaching");
        Console.Write("Select your position type (1-3): ");
        
        if (int.TryParse(Console.ReadLine(), out int positionType) && positionType >= 1 && positionType <= 3)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select the corresponding point for Education:\n" +
            "     0 - No schooling or elementary undergraduate\n" +
            "     1 - Elementary grauate or junior high school undergraduate\n" +
            "     2 - Junior high school graduate or senior high school undergraduate\n" +
            "     3 - Senior high school gradaute\n" +
            "     4 - Bachelor degree undergraduate\n" +
            "     5 - Vocational or associate degree holder\n" +
            "     6 - Bachelor degree graduate\n" +
            "     7 - Units of a master degree\n" +
            "     8 - Master degree graduate\n" +
            "     9 - Units of a doctoral degree\n" +
            "    10 - Doctaral degree graduate");
            Console.WriteLine("Select the corresponding point for Education (0-10): ");
            education = GetInput(0, 10);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select the corresponding point for Training:\n" +
            "     0 - Less than 8 hours of relevant training\n" +
            "     1 - At least 8 hours of relavant training\n" +
            "     2 - At least 16 hours of relavant training\n" +
            "     3 - At least 24 hours of relavant training\n" +
            "     4 - At least 32 hours of relavant training\n" +
            "     5 - At least 40 hours of relavant training\n" +
            "     6 - At least 48 hours of relavant training\n" +
            "     7 - At least 56 hours of relavant training\n" +
            "     8 - At least 64 hours of relavant training\n" +
            "     9 - At least 72 hours of relavant training\n" +
            "    10 - At least 80 hours of relavant training");  
            Console.WriteLine("Select the corresponding point for Training (0-10): ");
            training = GetInput(0, 10);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select the corresponding point for Experience:\n" +
            "     0 - Less than 1 month of relevant experience\n" +
            "     1 - More than 1 month but less than 1 year of relavant experience\n" +
            "     2 - At least 2 years of relavant experience\n" +
            "     3 - At least 3 years of relavant experience\n" +
            "     4 - At least 4 years of relavant experience\n" +
            "     5 - At least 5 years of relavant experience\n" +
            "     6 - At least 6 years of relavant experience\n" +
            "     7 - At least 7 years of relavant experience\n" +
            "     8 - At least 8 years of relavant experience\n" +
            "     9 - At least 9 years of relavant experience\n" +
            "    10 - At least 10 years of relavant experience");
            Console.WriteLine("Select the corresponding point for Experience (0-10): ");
            experience = GetInput(0, 10);

            Applicant applicant = null;
            switch (positionType)
            {
                case 1:
                    applicant = new Teaching(name, contactNumber, cityAddress, education, training, experience);
                    break;
                case 2:
                    applicant = new TeachingRelated(name, contactNumber, cityAddress, education, training, experience);
                    break;
                case 3:
                    applicant = new NonTeaching(name, contactNumber, cityAddress, education, training, experience);
                    break;
            }

            if (applicant != null)
            {
                string applicationNumber = applicant.GenerateApplicationNumber();
                Console.WriteLine($"Application Number: {applicationNumber}");
                double score = applicant.CalculateScore();
                Console.WriteLine($"Score: {score}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for position type. Please select a number between 1 and 3.");
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