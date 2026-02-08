public class Assignment
{
    private string _studentName;
    private string _topic;

    //Create a constructor for this class that receives a student name and topic and sets the member variables.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    }