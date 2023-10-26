using System;

public class HumanResource : Officer
{
    public bool _isQualified;
    
    public HumanResource(string name, string employeeNumber, bool isQualified)
        : base (name, employeeNumber)
    {
        _isQualified = isQualified;
    }

    public override void ViewApplicantSubmission()
    {
        string submissionDirectory = "C:\\ApplicantSubmissions";

        if (Directory.Exists(submissionDirectory))
        {
            Console.WriteLine("Viewing applicant submissions as Head of Office:");
            string[] submissionFiles = Directory.GetFiles(submissionDirectory);

            foreach (var submissionFile in submissionFiles)
            {
                string submissionContent = File.ReadAllText(submissionFile);
                Console.WriteLine($"Applicant Submission: {submissionContent}");
            }
        }

        else
        {
            Console.WriteLine("Applicant submission directory not found.");
        }
    }

    public override string PerformTask()
    {
        return _isQualified ? "Qualified" : "Disqualified";
    }
}