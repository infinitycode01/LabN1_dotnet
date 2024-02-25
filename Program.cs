namespace LabN1_dotnet;

class Program
{
    static void Main(string[] args)
    {
        Person firstPerson = new Person();
        Exam exam1 = new Exam();
        Student student1 = new Student();
        Student student2 = new Student(firstPerson, Education.Master, 130);


        Exam[] exams = new Exam[]
        {
            new Exam("Gaming", 123, new DateTime(2023, 11, 11, 2, 2, 2)),
            new Exam("asas", 44, new DateTime(2023, 11, 11, 2, 2, 2)),
            new Exam("sddd", 66, new DateTime(2023, 11, 11, 2, 2, 2))
        };
        student2.AddExams(exams);
        //Console.WriteLine(student2.ToString());


        Console.WriteLine(student2.ToString());

        

        //Console.WriteLine(firstPerson.ToShortString());


    }
}
