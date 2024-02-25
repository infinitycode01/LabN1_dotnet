namespace LabN1_dotnet;

class Program
{
    static void Main(string[] args)
    {
        /*Student student = new Student();
        Console.WriteLine(student.ToShortString());

        Console.WriteLine(student[Education.Bachelor]);
        Console.WriteLine(student[Education.Master]);
        Console.WriteLine(student[Education.SecondEducation]);

        Student studentAnother = new Student()
        {
            StudentData = new Person("Albert", "Alberto", new DateTime(2000, 2, 2, 2, 2, 2)),
            EducationForm = Education.Master,
            GroupNumber = 311,
            ExamsTaken = [new Exam(), new Exam(), new Exam()]
        };
        Console.WriteLine(studentAnother.ToString());


        Exam[] newExam = [new Exam("Math", 60, new DateTime(2024, 11, 11, 9, 0, 0)), 
            new Exam("C++", 60, new DateTime(2024, 11, 11, 9, 0, 0)), 
            new Exam("Java", 60, new DateTime(2024, 11, 11, 9, 0, 0))];

        studentAnother.AddExams(newExam);
        Console.WriteLine(studentAnother.ToString());*/
        int a = Environment.TickCount;
        Console.WriteLine("Input Rows and Columns like (*rows*',''-'' ''_'*columns*): ");
        string[] inputLine = Console.ReadLine().Split(',', '-', ' ', '_');
        int nRows = int.Parse(inputLine[0]);
        int nColumns = int.Parse(inputLine[1]);
        Console.WriteLine("Rows = " + nRows);
        Console.WriteLine("Columns = " + nColumns);


        Exam[] array1 = new Exam[nRows * nColumns];
        Exam[,] array2 = new Exam[nRows, nColumns];
        Exam[][] array3 = new Exam[nRows][];
        for (int i = 0; i < nRows; i++)
        {
            array3[i] = new Exam[nColumns];
        } 

        for (int i = 0; i < nRows; i++)
        {
            for (int j = 0; j < nColumns; j++)
            {
                array1[i * nColumns + j] = new Exam();
                array2[i, j] = new Exam();
                array3[i][j] = new Exam();
            }
        }
        
        int start, end, delta;

        start = Environment.TickCount;
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i].ExamDate = new DateTime(2222, 12, 12, 12, 12, 12);
        }
        end = Environment.TickCount;
        delta = end - start;
        Console.WriteLine("Operation time for array1 = " + delta);

        start = Environment.TickCount;
        for (int i = 0; i < nRows; i++)
        {
            for (int j = 0; j < nColumns; j++)
            {
                array2[i, j].ExamDate = new DateTime(2222, 12, 12, 12, 12, 12);
            }
        }
        end = Environment.TickCount;
        delta = end - start;
        Console.WriteLine("Operation time for array2 = " + delta);

        start = Environment.TickCount;
         for (int i = 0; i < nRows; i++)
        {
            for (int j = 0; j < nColumns; j++)
            {

                array3[i][j].ExamDate = new DateTime(2222, 12, 12, 12, 12, 12);
            }
        }
        end = Environment.TickCount;
        delta = end - start;
        Console.WriteLine("Operation time for array3 = " + delta);

        int b = Environment.TickCount;

        Console.WriteLine(b - a);
        
    }
}
