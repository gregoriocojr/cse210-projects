using System;

public class HeadOfOffice : Officer
{
    public bool _isApprove;
    
    public HeadOfOffice(string name, string employeeNumber, bool isApprove)
        : base (name, employeeNumber)
    {
        _isApprove = isApprove;
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
        return _isApprove ? "Approved" : "Disapproved";
    }
}