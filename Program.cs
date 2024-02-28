namespace LabN1_dotnet;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
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
        Console.WriteLine(studentAnother.ToString());

        Console.WriteLine("Input Rows and Columns like (*rows*',''-'' ''_'*columns*): ");
        string[] inputLine = Console.ReadLine().Split(',', '-', ' ', '_');
        int nRows = int.Parse(inputLine[0]);
        int nColumns = int.Parse(inputLine[1]);
        Console.WriteLine("Rows = " + nRows);
        Console.WriteLine("Columns = " + nColumns);


        Exam[] array1 = new Exam[nRows * nColumns];
        Exam[,] array2 = new Exam[nRows, nColumns];
      
        int start, end, delta;

        start = Environment.TickCount;
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = new Exam("Probraming", 100, new DateTime(2024, 6, 13));
        }
        end = Environment.TickCount;
        delta = end - start;
        Console.WriteLine("Operation time for array1 = " + delta);

        start = Environment.TickCount;
        for (int i = 0; i < nRows; i++)
        {
            for (int j = 0; j < nColumns; j++)
            {
                array1[i] = new Exam("Probraming", 100, new DateTime(2024, 6, 13));
            }
        }
        end = Environment.TickCount;
        delta = end - start;
        Console.WriteLine("Operation time for array2 = " + delta);

        int totalElements = nRows * nColumns;
        Random rnd = new Random();

        int accum = 0;
        int rows = 0;

        do
        {
            rows++;
            accum += rows;
        } 
        while (accum < totalElements);

        Exam[][] array3 = new Exam[rows][];
        start = Environment.TickCount;
        for (int i = 0; i < rows-1; i++)
        {
            array3[i] = new Exam[i + 1];
            for (int j = 0; j < i + 1; j++)
            {
                array3[i][j] = new Exam("Probraming", 100, new DateTime(2024, 6, 13));
            }
        }

        int lastFewElements = rows - (accum - totalElements);
        if (lastFewElements > 0)
        {
            array3[rows - 1] = new Exam[lastFewElements];

            for (int i = 0; i < lastFewElements; i++)
            {
                array3[rows - 1][i] = new Exam("Probraming", 100, new DateTime(2024, 6, 13));
            }

        }
        end = Environment.TickCount;
        delta = end - start;
        Console.WriteLine("Operation time for array3 = " + delta);
    }
}
