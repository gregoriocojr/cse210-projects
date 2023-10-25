using System;

public abstract class Applicant
{
    private string _name;
    private string _contactNumber;
    private string _cityAddress;
    protected string _applicationNumber;

    public string Name => _name;
    public string ContactNumber => _contactNumber;
    public string CityAddress => _cityAddress;
    public string ApplicationNumber => _applicationNumber;

    public Applicant(string name, string contactNumber, string cityAddress)
    {
        _name = name;
        _contactNumber = contactNumber;
        _cityAddress = cityAddress;
    }

    public abstract string GenerateApplicationNumber();
    
    public abstract double CalculateScore();
}