namespace LabN1_dotnet;

public class Exam
{
    public string SubjectName { get; set; }
    public int Assessment { get; set; }
    public System.DateTime ExamDate { get; set; }

    public Exam(string name, int assessment, System.DateTime date)
    {
        SubjectName = name;
        Assessment = assessment;
        ExamDate = date;
    }

    public Exam()
    {
        SubjectName = "Programming";
        Assessment = 100;
        ExamDate = new DateTime(2024, 6, 12, 9, 0, 0);
    }

    public override string ToString()
    {
        return "Subject name: " + SubjectName + "\n" + "Assessment: " + Assessment + "\n" + "Exam date: " + ExamDate;
    }
}