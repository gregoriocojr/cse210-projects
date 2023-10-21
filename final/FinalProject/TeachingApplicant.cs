using System;

public class TeachingApplicant : Applicant
{
    public TeachingApplicant(string name, string contactNumber, string cityAddress)
        : base (name, contactNumber, cityAddress)
    {}

    public override string GenerateApplicantionNumber()
    {
        int applicantionCounterForTP = 1;
        string xxxPart = applicantionCounterForTP.ToString("D3");
        applicantionCounterForTP ++;
        return $"{xxxPart} - TP";
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

