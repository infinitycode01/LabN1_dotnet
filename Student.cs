    namespace LabN1_dotnet;

    public class Student
    {
        private Person studentData;
        private Education educationForm;
        private int groupNumber;
        private Exam[] examsTaken;

        public Student(Person studentData, Education educationForm, int groupNumber)
        {
            this.studentData = studentData;
            this.educationForm = educationForm;
            this.groupNumber = groupNumber;
            //examsTaken = new Exam[3]; // як зробити щоб не працювати з null??
        }

        public Student()
        {
            studentData = new Person();
            educationForm = Education.Bachelor;
            groupNumber = 111;
            examsTaken = new Exam[3];
            examsTaken[0] = new Exam();
            examsTaken[1] = new Exam();
            examsTaken[2] = new Exam();
        }

        public Person StudentData
        {
            get { return studentData; }
            init { studentData = value; }
        }

        public Education EducationForm
        {
            get { return educationForm; }
            init { educationForm = value; }
        }

        public int GroupNumber
        {
            get { return groupNumber; }
            init { groupNumber = value; }
        }

        public Exam[] ExamsTaken
        {
            get { return examsTaken; }
            init { examsTaken = value; }
        }

        public double AverageGrade
        {
            get
            {
                double gradeSum = 0;
                for (int i = 0; i < examsTaken.Length; i++)
                {
                    gradeSum += examsTaken[i].Assessment;
                }
                return gradeSum / examsTaken.Length;
            }
        }

        public bool this[Education index]
        {
            get
            {
                if (this.educationForm == index)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void AddExams(params Exam[] newExams)
        {
            examsTaken = new Exam[newExams.Length];
            for (int i = 0; i < examsTaken.Length; i++)
            {
                examsTaken[i] = newExams[i]; 
            }

            /*int availableSlots = examsTaken.Length - examsTaken.Count(exam => exam != null);
            if (newExams.Length > availableSlots)
            {
                Console.WriteLine("Not enough space to add new exams");
                return;
            }*/

            /*int index = 0;
            for (int i = 0; i < examsTaken.Length; i++)
            {
                if (examsTaken[i] == null)
                {
                    examsTaken[i] = newExams[index];
                    index++;
                }

                if (index >= newExams.Length)
                {
                    break;
                }
            }*/
            Console.WriteLine("Exams was added successfully");
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
    
            sb.AppendLine("\x1b[1mStudent Data:\x1b[0m");
            sb.AppendLine(studentData.ToString());
            sb.AppendLine($"\x1b[1mEducation Form:\x1b[0m {educationForm}");
            sb.AppendLine($"\x1b[1mGroup Number:\x1b[0m {groupNumber}");
            sb.AppendLine("\x1b[1mExams Taken:\x1b[0m");
            foreach (var exam in examsTaken)
            {
                if (exam != null)
                {
                    sb.AppendLine(exam.ToString());
                }
            }

            return sb.ToString();
        }

        public string ToShortString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
    
            sb.AppendLine("\x1b[1mStudent Data:\x1b[0m");
            sb.AppendLine(studentData.ToString());
            sb.AppendLine($"\x1b[1mEducation Form:\x1b[0m {educationForm}");
            sb.AppendLine($"\x1b[1mGroup Number:\x1b[0m {groupNumber}");
            sb.AppendLine($"\x1b[1mAverage grade:\x1b[0m {AverageGrade}");

            return sb.ToString();
        }
    }

