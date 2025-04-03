public class MathAssignment : Assignment
{
    //Setting the variables
    private string _textbookSection;
    private string _problems;

    //Setting constructors
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //Setting the Method: GetHomeworkList()
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}