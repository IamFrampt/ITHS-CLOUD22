// Övingar under lektionen

//Variabler

public class User
{
    public string Name = string.Empty;
    private string Password = "abc123";

    public void SetPassWord(string password, string oldPassword)
    {

        if (oldPassword.Equals(Password))
        {
            Password = password;
            Console.WriteLine("Password changed!");
        }
        else
            Console.WriteLine("Can't change password!.");
    }

    public void ShowPassword()
    {
        Console.WriteLine(Password);
    }
}
