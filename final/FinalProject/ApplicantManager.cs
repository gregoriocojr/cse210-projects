using System;
using System.Collections.Generic;
using System.IO;

public class ApplicantManager
{
    private List<Applicant> _applicants;

    public ApplicantManager()
    {
        _applicants = new List<Applicant>();
    }

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
    }

    public void ApplicantOption()
    {
        string applicantChoice = "";

        Console.WriteLine("What do you want to do?\n" +
            "1. Begin a new application\n" +
            "2. Continue a saved application\n" +
            "3. View status of submitted application\n" +
            "4. Quit");
        Console.Write("Please enter your choice: ");
        applicantChoice = Console.ReadLine();
    }
}