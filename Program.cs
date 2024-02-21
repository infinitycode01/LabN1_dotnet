namespace LabN1_dotnet;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Its work\nHi");
        Person firstPerson = new Person();
        Console.WriteLine(firstPerson.ToString());
        Console.WriteLine(firstPerson.ToShortString());
    }
}
