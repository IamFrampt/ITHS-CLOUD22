var people = new[]
{
    new {LastName = "Eriksson", FirstName = "Mikael",Age = 27},
    new {LastName = "Jonsson", FirstName = "Paulina",Age = 41},
    new {LastName = "Anastasiadis", FirstName = "Ioannis",Age = 54},
    new {LastName = "Länn", FirstName = "Pontus",Age = 64},

};

var filteredArray = people.Where(p => p.LastName.Length < 5)
    .Select(p => new { Name = $"{p.FirstName} {p.LastName}", UserName = (p.FirstName.Substring(0, 3) + p.LastName.Substring(0, 3)).ToLower() })
    .ToList();

foreach (var person in filteredArray)
{
    Console.WriteLine(person);
}