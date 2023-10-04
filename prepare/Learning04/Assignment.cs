// using System;

// public class Assignment
// {
//     private string _studentName;
//     private string _topic;

//     public string GetStudentName()
//     {
//         return _studentName;
//     }

//     public void SetStudentName(string studentName)
//     {
//         _studentName = studentName;
//     }

//     public string GetTopic()
//     {
//         return _topic;
//     }

//     public void SetTopic(string topic)
//     {
//         _topic = topic;
//     }

//     public string GetSummary()
//     {
//         return ($"{_studentName} - {_topic}");
//     }
// }

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // We will provide Getters for our private member variables so they can be accessed
    // later both outside the class as well is in derived classes.
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}