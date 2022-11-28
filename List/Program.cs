List<string> countries = new List<string>();

countries.Add("Sweden"); countries.Add("Norway"); countries.Add("Denmark"); countries.Add("Finland"); countries.Add("Iceland");

countries.AddRange(new string[] {"Spain","Belgium","Italy"});


Console.WriteLine(String.Join(", ", countries));
Console.WriteLine();

foreach (string country in countries)
    Console.WriteLine(country);
Console.WriteLine();

countries.ForEach(country => Console.WriteLine(country));
Console.WriteLine();

for (int i = 0; i < countries.Count; i++)
{
    Console.WriteLine(countries[i]);
}