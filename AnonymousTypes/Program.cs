var anonymous = new { x = 5, y = 0.34f, z = 100L, name = "Mikael" };
//Console.WriteLine(anonymous);

var people = new[]
{
    new {LastName = "Eriksson", FirstName = "Mikael",Age = 27},
    new {LastName = "Eriksson", FirstName = "Mikael",Age = 27},
    new {LastName = "Eriksson", FirstName = "Mikael",Age = 27},
    new {LastName = "Eriksson", FirstName = "Mikael",Age = 27},

};

foreach(var person in people)
Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");

var personas = new
{
    name = "Mikael Eriksson",
    age = 27,
    contactInfo = new{ email = "mikael.eriksson@iths.com", phone = "0723003320" }

};

Console.WriteLine(personas.contactInfo.email);


