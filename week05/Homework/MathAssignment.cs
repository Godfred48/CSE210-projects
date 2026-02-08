public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;    

    //creating a constructor for the class
    public MathAssignment (string studentName,string topic, string textbookSection , string problem) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }
        public string GetHomeworkList()
        {
            return $"{GetSummary()} - Section {_textbookSection} Problem {_problem}";
        }
    }
