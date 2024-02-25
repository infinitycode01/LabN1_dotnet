namespace LabN1_dotnet;

public class Person
{
    private string name;
    private string surname;
    private System.DateTime birthDate;


    public Person(string name, string surname, System.DateTime birthDate)
    {
        this.name = name;
        this.surname = surname;
        this.birthDate = birthDate;
    }

    public Person()
    {
        this.name = "Dmytro";
        this.surname = "Badichel";
        this.birthDate = new DateTime(2004, 9, 11, 7, 7, 7);
    }

    public string Name
    {
        get => name; // питання до викладача get { return name; } best practice??
        init => name = value;
    }

    public string Surname
    {
        get => surname;
        init => surname = value;
    }

    public System.DateTime BirthDate
    {
        get => birthDate;
        init => birthDate = value;
    }

    public int BirthYear
    {
        get => birthDate.Year;
        set
        {
            birthDate = new DateTime(value, birthDate.Month, birthDate.Day);
        }
    }

    public override string ToString()
    {
        return "Name: " + Name + "\n" + "Surname: " + Surname + "\n" + "Birth date: " + BirthDate;
    }

    public string ToShortString()
    {
        return "Name: " + Name + "\n" + "Surname: " + Surname;
    }
}