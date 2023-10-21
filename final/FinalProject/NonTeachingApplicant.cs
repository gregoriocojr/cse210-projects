using System;

public class NonTeachingApplicant : Applicant
{
    public NonTeachingApplicant(string name, string contactNumber, string cityAddress)
        : base (name, contactNumber, cityAddress)
    {}

    public override string GenerateApplicantionNumber()
    {
        int applicantionCounterForNTP = 1;
        string xxxPart = applicantionCounterForNTP.ToString("D3");
        applicantionCounterForNTP ++;
        return $"{xxxPart} - NTP";
    }

    public override void EnterCredentials()
    {
        ;
    }

    public override void SubmitApplication()
    {
        ;
    }

    public override void EditSubmission()
    {
        ;
    }

    public override string CheckApplicationStatus()
    {
        return "More codes to come";
    }
}

