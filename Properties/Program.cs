

var Mikael = new Person("Mikael", "Eriksson");
var Paulina = new Person("Paulina", "Jonsson");
var Ioannis = new Person("Ioannis");

Console.WriteLine(Person.Type);
Console.WriteLine(Mikael.Name);
Console.WriteLine(Paulina.Name);
Console.WriteLine(Ioannis.Name);
Mikael.Length = 1.83;
Console.WriteLine(Mikael.Length);

public class Person
{
    public string Name = String.Empty;
    public static string Type = "Human";

    private double length;
    public double Length
    {
        get{ return this.length; } 
        set { this.length = Math.Clamp(value, 1.0, 2.3); }
    }

    public Person(string firstName, string lastName)
    {
        Name = firstName + " " + lastName;

        if (Name == "Paulina Jonsson")
        {
            Name = "The Great " + Name;
        }
    }
    public Person(string firstName)
    {
        Name = firstName + " Unknown";

    }
    public void SetLength(double length)
    {
        this.length = Math.Clamp(length,1.0,2.1);
    }
    public double GetLength()
    {
        return this.length;
    }

}

