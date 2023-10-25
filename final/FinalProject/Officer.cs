using System;

public abstract class Officer
{
    private string _name;
    private string _employeeNumber;

    public string Name => _name;
    public string EmployeeNumber => _employeeNumber;

    public Officer(string name, string employeeNumber)
    {
        _name = name;
        _employeeNumber = employeeNumber;
    }
    
    public abstract void ViewApplicantSubmission();
    // {
        // string submissionDirectory = "C:\\ApplicantSubmissions";

        // if (Directory.Exists(submissionDirectory))
        // {
        //     Console.WriteLine("Viewing applicant submissions as Head of Office:");
        //     string[] submissionFiles = Directory.GetFiles(submissionDirectory);

        //     foreach (var submissionFile in submissionFiles)
        //     {
        //         string submissionContent = File.ReadAllText(submissionFile);
        //         Console.WriteLine($"Applicant Submission: {submissionContent}");
        //     }
        // }

        // else
        // {
        //     Console.WriteLine("Applicant submission directory not found.");
        // }
    // }

    public abstract void PerformTask();
}