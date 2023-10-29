using System;

public class Teaching : Applicant
{
    public double _education;
    public double _training;
    public double _experience;

    private static int _applicationCounterForTP = 1;

    public Teaching(string name, string contactNumber, string cityAddress, double education, double training, double experience, string applicationNumber)
        : base (name, contactNumber, cityAddress, education, training, experience)
    {
        // ApplicationNumber = GenerateApplicationNumber();
    }

    public override string GenerateApplicationNumber()
    {
        string xxxPart = _applicationCounterForTP.ToString("D3");
        _applicationCounterForTP++;
        string applicationNumber = $"{xxxPart} - TP";
        return applicationNumber;
    }

    public override double CalculateScore()
    {
        double score = _education * 4 + _training * 3 + _experience * 3;
        return score;
    }
}