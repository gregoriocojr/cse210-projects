using System;

public class Teaching : Applicant
{
    public int _education;
    public int _training;
    public int _experience;

    private static int _applicationCounterForTP = 1;

    public Teaching(string name, string contactNumber, string cityAddress, int education, int training, int experience, string ApplicationNumber)
        : base (name, contactNumber, cityAddress, education, training, experience)
    {}

    public override string GenerateApplicationNumber()
    {
        string xxxPart = _applicationCounterForTP.ToString("D3");
        _applicationCounterForTP++;
        string ApplicationNumber = $"{xxxPart} - TP";
        return ApplicationNumber;
    }

    public override double CalculateScore()
    {
        double score = _education/10 * 40 + _training/10 * 30 + _experience/10 * 30;
        return score;
    }
}