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
        this.birthDate = new DateTime(2004, 9, 11);
    }

    public string Name
    {
        get { return name; }
    }

    public string Surname
    {
        get { return surname; }
    }

    public System.DateTime BirthDate
    {
        get { return birthDate; }
    }

    public int BirthYear
    {
        get { return birthDate.Year; }
        set
        {
            birthDate = new DateTime(value, birthDate.Month, birthDate.Day);
        }
    }
}