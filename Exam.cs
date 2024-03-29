namespace LabN1_dotnet;

public class Exam
{
    public string SubjectName { get; init; }
    public int Assessment { get; init; }
    public System.DateTime ExamDate { get; init; }

    public Exam(string name, int assessment, System.DateTime date)
    {
        SubjectName = name;
        Assessment = assessment;
        ExamDate = date;
    }

    public Exam(): this(name: "Programming", assessment: 100, date: new DateTime(2024, 6, 12, 9, 0, 0)) { }


    public override string ToString()
    {
        return "Subject name: " + SubjectName + "\n" 
            + "Assessment: " + Assessment + "\n" 
            + "Exam date: " + ExamDate;
    }
}