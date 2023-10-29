using System;

public class TeachingRelated : Applicant
{
    public double _education;
    public double _training;
    public double _experience;

    private static int _applicationCounterForTRP = 1;

    public TeachingRelated(string name, string contactNumber, string cityAddress, double education, double training, double experience, string ApplicationNumber)
        : base (name, contactNumber, cityAddress, education, training, experience)
    {
        // ApplicationNumber = GenerateApplicationNumber();
    }

    public override string GenerateApplicationNumber()
    {
        string xxxPart = _applicationCounterForTRP.ToString("D3");
        _applicationCounterForTRP++;
        string applicationNumber = $"{xxxPart} - TRP";
        return applicationNumber;
    }

    public override double CalculateScore()
    {
        double score = _education * 3.5 + _training * 3 + _experience * 3.5;
        return score;
    }
}