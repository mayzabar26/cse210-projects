public class WritingAssignment : Assignment
{
    //Setting the variables
    private string _title;


    //Setting constructors
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic) 
    {
        _title = title;
    }


    //Setting the Method: GetWritingInformation()
    public String GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}\n";
    }
}