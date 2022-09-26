public class Person3
{
    private string firstName;
    private string lastName;
    protected string[] FullName = new string[2];

    public Person3(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.FullName[0] = firstName;
        this.FullName[1] = lastName;
    }
    public Person3(string Name)
    {
        this.FullName = Name.Split(" ");
    }

    public string FirstName
    {
        get { return this.FullName[0]; }
    }
    public string LastName
    {

        get { return this.FullName[1]; }
    }
    public string Name
    {

        get { return this.FullName[0] + " " +this.FullName[1]; }
    }


}

