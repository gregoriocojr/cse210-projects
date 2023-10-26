using System;

public class TeachingRelated : Applicant
{
    public int _education;
    public int _training;
    public int _experience;

    private static int _applicationCounterForTRP = 1;

    public TeachingRelated(string name, string contactNumber, string cityAddress, int education, int training, int experience)
        : base (name, contactNumber, cityAddress, education, training, experience)
    {}

    public override string GenerateApplicationNumber()
    {
        string xxxPart = _applicationCounterForTRP.ToString("D3");
        _applicationCounterForTRP++;
        string ApplicationNumber = $"{xxxPart} - TRP";
        return ApplicationNumber;
    }

    public override double CalculateScore()
    {
        double score = _education/10 * 35 + _training/10 * 30 + _experience/10 * 35;
        return score;
    }
}