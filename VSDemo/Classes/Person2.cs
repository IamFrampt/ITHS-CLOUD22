using System.Runtime.Intrinsics.X86;

public class Person2
{
    private string firstName;
    private string lastName;
    private string title = string.Empty;
    private double WeightInKg;
    private double LengthInMeters;


    public Person2(string firstName, string lastName, string Title)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.title = Title;
    }
    public Person2(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    public Person2(double weight, double length)
    {
        this.WeightInKg = weight;
        this.LengthInMeters = length;
    }

    public double BMI
    {
        get { return Math.Round(this.WeightInKg / Math.Pow(this.LengthInMeters, 2),2); }
    }

    public string FullName
    {
        get{ return title.Length > 0 ? title + " " + firstName + " " + lastName : firstName + " " + lastName; }
    }

}