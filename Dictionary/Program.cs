Dictionary<string, string> countries = new Dictionary<string, string>();

countries.Add("sverige", "Sweden");
countries.Add("norge", "Norway");
countries.Add("danmark", "Denmark");
countries.Add("finland", "Finland");
countries.Add("island", "Iceland");

string userInput = Console.ReadLine().ToLower();


if (countries.ContainsKey(userInput))
    Console.WriteLine(countries[userInput]);
else
    Console.WriteLine("Not found!");

if (countries.TryGetValue(userInput, out string result))
    Console.WriteLine(result);
else
    Console.WriteLine("Not found!");

Console.WriteLine();

foreach (string country in countries.Keys)
    Console.WriteLine(country);

Console.WriteLine();

foreach (KeyValuePair<string, string> country in countries)
    Console.WriteLine($"{country.Key} = {country.Value}");

Console.WriteLine();

Dictionary<string, User> users = new Dictionary<string, User>()
{
    {"Mikael", new User(){userName = "Mikael", fullName = "Mikael Eriksson", password = "abc123"} },
    {"Paulina", new User(){userName = "Paulina", fullName = "Paulina Jonsson", password = "def123"} },
    {"Ioannis", new User(){userName = "Ioannis", fullName = "Ioannis Anastasiadis", password = "ghi123"} },
};

string username = string.Empty;

do
{

    Console.Write("Enter username: ");
    username = Console.ReadLine();

    if (users.ContainsKey(username))
    {
        User user = users[username];
        Console.WriteLine($"User: {user.userName}");
        Console.WriteLine($"Full name: {user.fullName}");
        Console.WriteLine($"Password: {user.password}");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("User not found!");
        Console.WriteLine();
    }

} while (username != string.Empty);



class User
{
    public string fullName { get; set; }

    public string userName { get; set; }

    public string password { get; set; }
}







