using System;

public abstract class Applicant
{
    private string _name;
    private string _contactNumber;
    private string _cityAddress;
    private double _education;
    private double _training;
    private double _experience;
    protected string _applicationNumber;

    public string Name => _name;
    public string ContactNumber => _contactNumber;
    public string CityAddress => _cityAddress;
    public double Education => _education;
    public double Training => _training;
    public double Experience => _experience;
    public string ApplicationNumber => _applicationNumber;

    public Applicant(string name, string contactNumber, string cityAddress, double education, double training, double experience)
    {
        _name = name;
        _contactNumber = contactNumber;
        _cityAddress = cityAddress;
        _education = education;
        _training = training;
        _experience = experience;
    }

    public abstract string GenerateApplicationNumber();
    
    public abstract double CalculateScore();
}