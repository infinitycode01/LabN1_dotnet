namespace LabN1_dotnet;

class Program
{
    static void Main(string[] args)
    {
        Person firstPerson = new Person("Dima", "Rora", new DateTime(2004, 11, 11));
        firstPerson.BirthYear = 2020;

        Console.WriteLine(firstPerson.ToString());

        //Console.WriteLine(firstPerson.ToShortString());


    }
}
