using System;

public class NonTeaching : Applicant
{
    public double _education;
    public double _training;
    public double _experience;

    private static int _applicationCounterForNTP = 1;

    public NonTeaching(string name, string contactNumber, string cityAddress, double education, double training, double experience, string ApplicationNumber)
        : base (name, contactNumber, cityAddress, education, training, experience)
    {
        // ApplicationNumber = GenerateApplicationNumber();
    }

    public override string GenerateApplicationNumber()
    {
        string xxxPart = _applicationCounterForNTP.ToString("D3");
        _applicationCounterForNTP++;
        string applicationNumber = $"{xxxPart} - NTP";
        return applicationNumber;
    }

    public override double CalculateScore()
    {
        double score = _education * 3 + _training * 3.5 + _experience * 3.5;
        return score;
    }
}