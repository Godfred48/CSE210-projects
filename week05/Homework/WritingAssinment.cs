public class WritingAssignment : Assignment
{
    private string _title;

    //creating a constructor for the class
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{GetSummary()} - Title: {_title}";
    }
}