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
}