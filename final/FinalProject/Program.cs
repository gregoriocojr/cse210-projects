using System;

class Program
{
    static ApplicantManager applicantManager = new ApplicantManager();
    static OfficerManager officerManager = new OfficerManager();

    static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Applicant Evaluation Program");
            Console.WriteLine("");
            Console.WriteLine("Identify User:\n" +
                "1. Applicant\n" +
                "2. Officer");
            Console.Write("Please identify user: ");
            string userAction = Console.ReadLine();

            switch (userAction)
            {
                case "1":
                    applicantManager.ApplicantAction();
                    break;

                case "2":
                    officerManager.OfficerAction();
                    break;
            }
        } while (true);
    }
}