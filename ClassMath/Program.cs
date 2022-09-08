Console.WriteLine("PI: " + Math.PI);
Console.WriteLine("---------------------");

//Absolutvärde
int x1 = 5;
int x2 = 8;
Console.WriteLine("Abs(8-5): " + Math.Abs(x1 - x2)); //Aboslutvärdet av 5-8 
Console.WriteLine("---------------------");

//Avrundning
Console.WriteLine("Floor(3.4f): " + Math.Floor(3.4f)); //Närmsta heltal "Neråt"
Console.WriteLine("Ceiling(3.4f): " + Math.Ceiling(3.4f)); //Närmsta heltal "Uppåt"
Console.WriteLine("Round(3.4f): " + Math.Round(3.4f)); //Närmsta heltal
Console.WriteLine("Truncate(3.4f): " + Math.Truncate(3.4f)); // Tar ut heltalet ur en double/float/decimal
Console.WriteLine("---------------------");

//Min, Max, Clamp
Console.WriteLine("Min(5-8): " + Math.Min(5, 8)); //Minsta värdet av 5 och 8
Console.WriteLine("Max(5-8): " + Math.Max(5, 8)); //Största värdet av 5 och 8
Console.WriteLine("Clamp(5,0,100): " + Math.Clamp(5, 0, 100)); // om x i (x,0,100) finns mellan 0-100 skriver den ut x
Console.WriteLine("---------------------");

//Power
Console.WriteLine("Pow(2^4): " + Math.Pow(2, 4)); //2 upphöjt med 4
Console.WriteLine("---------------------");

//Square root
Console.WriteLine("Sqrt(9): " + Math.Sqrt(9)); // Kvadratroten ur 9
Console.WriteLine("---------------------");
