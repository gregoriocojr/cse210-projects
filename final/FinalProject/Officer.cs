using System;

public abstract class Officer
{
    private string _name;
    private string _employeeNumber;

    public string Name => _name;
    public string EmployeeNumber => _employeeNumber;

    public Officer(string name, string employeeNumber)
    {
        _name = name;
        _employeeNumber = employeeNumber;
    }
    
    public abstract void ViewApplicantSubmission();

    public abstract void PerformTask();
}