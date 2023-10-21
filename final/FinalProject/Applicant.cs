using System;

public abstract class Applicant
{
    private string _name;
    private string _contactNumber;
    private string _cityAddress;

    public string Name => _name;
    public string ContactNumber => _contactNumber;
    public string CityAddress => _cityAddress;

    public Applicant(string name, string contactNumber, string cityAddress)
    {
        _name = name;
        _contactNumber = contactNumber;
        _cityAddress = cityAddress;
    }

    public abstract string GenerateApplicantionNumber();

    public abstract void EnterCredentials();

    public abstract void SubmitApplication();

    public abstract void EditSubmission();

    public abstract string CheckApplicationStatus();
}