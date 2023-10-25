public class NonTeaching : Applicant
{
    public int _education;
    public int _training;
    public int _experience;

    private static int _applicationCounterForNTP = 1;

    public NonTeaching(string name, string contactNumber, string cityAddress, int education, int training, int experience)
        : base(name, contactNumber, cityAddress)
    {
        _education = education;
        _training = training;
        _experience = experience;
    }

    public override string GenerateApplicantionNumber()
    {
        string xxxPart = _applicationCounterForNTP.ToString("D3");
        _applicationCounterForNTP++;
        string ApplicationNumber = $"{xxxPart} - NTP";
        return ApplicationNumber;
    }

    public override double CalculateScore()
    {
        double score = _education / 10 * 30 + _training / 10 * 35 + _experience / 10 * 35;
        return score;
    }
}
