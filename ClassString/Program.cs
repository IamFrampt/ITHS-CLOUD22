string name = "Fredrik dricker cola, och tycker det är gott";

//REPLACE & REMOVE
Console.WriteLine("Replace r med x: " + name.Replace('r', 'x'));
Console.WriteLine("Replace dri med x: " + name.Replace("dri", "x"));
Console.WriteLine("Remove bokstaven i: "+name.Remove(5,1));
Console.WriteLine("---------------------------");

//INSERT
Console.WriteLine("Insert ordet inte i strängen: "+name.Insert(16, "inte "));
Console.WriteLine("---------------------------");

//UPPER & LOWER
Console.WriteLine("ToLower: " + name.ToLower());
Console.WriteLine("ToUpper: " + name.ToUpper());
Console.WriteLine("---------------------------");

//SPLIT
string[] words = name.Split(',');
foreach (string word in words)
    Console.WriteLine(word);
Console.WriteLine("---------------------------");

//TRIM
Console.WriteLine("      Hej       ".TrimStart() + "<<");
Console.WriteLine("      Hej       ".TrimEnd() + "<<");
Console.WriteLine("      Hej       ".Trim() + "<<");
Console.WriteLine("---------------------------");

//INDEX
Console.WriteLine(name.IndexOf("dri"));
Console.WriteLine(name.LastIndexOf("dri"));
Console.WriteLine("---------------------------");

//Börjar vid första index och fortsätter till andra index.
Console.WriteLine(name.Substring(10,15));
Console.WriteLine("---------------------------");

//Padleft / Padright
Console.WriteLine("Hej".PadLeft(10));
Console.WriteLine("Hej".PadRight(10)+"Hej.");
Console.WriteLine("---------------------------");

//Tom sträng
string myString = string.Empty;
//string.IsNullOrEmpty;

//Konktatinera, Slå samman ord
string[] cities = { "Stockholm", "Göteborg", "Motala", "Borås" };
Console.WriteLine(string.Concat(cities));
Console.WriteLine(string.Join(" - ", cities));


