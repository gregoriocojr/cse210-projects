using System;

public class TeachingRelatedApplicant : Applicant
{
    public TeachingRelatedApplicant(string name, string contactNumber, string cityAddress)
        : base (name, contactNumber, cityAddress)
    {}

    public override string GenerateApplicantionNumber()
    {
        int applicantionCounterForTRP = 1;
        string xxxPart = applicantionCounterForTRP.ToString("D3");
        applicantionCounterForTRP ++;
        return $"{xxxPart} - TRP";
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

