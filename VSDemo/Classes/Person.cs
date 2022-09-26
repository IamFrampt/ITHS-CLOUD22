using System.Diagnostics.Metrics;

public class Person
{
    public string Name;
    public Person Mother;
    public Person Father;

    public Person(string name)
    {
        this.Name = name;
    }
}