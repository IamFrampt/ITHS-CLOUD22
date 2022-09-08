// Övingar under lektionen

//Variabler

/* Övningar 1

Console.WriteLine("Skriv in två tal.");
Console.Write("Tal 1: ");
int Tal1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Tal 2: ");
int Tal2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Multiplikationen av {Tal1} och {Tal2} är {Tal1 * Tal2}");
*/

/* Övning 2

Console.Write("Skriv in ditt förnamn: ");
string firstName = Console.ReadLine();
Console.Write("Skriv in ditt efternamn: ");
string lastName = Console.ReadLine();
Console.WriteLine($"Hej, {firstName} {lastName}.");
*/

/* Övning 3

Console.Write("Skriv in ditt namn: ");
string firstName2 = Console.ReadLine();

if (checkMyName(firstName2) == true)
{
    Console.WriteLine($"Hej {firstName2}, du är personen jag tänkte på.");
}
else
    Console.WriteLine($"Hej {firstName2}, vem är du?");

bool checkMyName(string name)
{
    if (name == "Mikael" || name == "mikael")
        return true;
    else
        return false;
}
*/

/*Övning 4

Console.WriteLine("Skriv in ett tal.");
Console.Write("Ditt tal: ");
double dittTal = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{dittTal * 2} är dubbla värdet av {dittTal}");
Console.WriteLine($"{dittTal / 2} är halva värdet av {dittTal}");
*/

//Loopar

/*ÖVNING 5
for (int i = 20; i <=30;i++)
{
    Console.Write($"{i} ");
}
Console.ReadKey();
Console.Clear();
*/

/*ÖVNING 6
for (int i = 0; i <= 30; i++)
{
    if(i%2 == 0)
    Console.Write($"{i} ");
}

Console.ReadKey();
Console.Clear();
*/

/*ÖVNING 7
for (int i = 1; i <= 30; i++)
{
    if (i % 3 != 0)
        Console.Write($"{i} ");
    else 
        Console.Write($"hej ");
}

Console.ReadKey();
Console.Clear();
*/

/*ÖVNING 8
Console.Write("Skriv ett tal: ");
int tal = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{tal} * {i} = {tal*i}");
}
Console.ReadKey();
Console.Clear();
*/

/*ÖVNING  9
Console.Write("Bredd: ");
int bredd = Convert.ToInt32(Console.ReadLine());
Console.Write("Höjd: ");
int hojd = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < hojd; i++)
{
    for (int j = 0; j < bredd; j++)
    {
        Console.Write($"X");
    }
    Console.WriteLine("");
}
*/

/* ÖVNING 10
Console.Write("Bredd: ");
int bredd = Convert.ToInt32(Console.ReadLine());
Console.Write("Höjd: ");
int hojd = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= hojd; i++)
{
    for (int j = 1; j <= bredd ; j+=2)
    {
        Console.Write($"X");
        if(j!=bredd)
            Console.Write($"O");
    }
    Console.WriteLine("");
}
*/

/* ÖVNING 11
Console.Write("Bredd: ");
int bredd = Convert.ToInt32(Console.ReadLine());
Console.Write("Höjd: ");
int hojd = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= hojd; i++)
{
    for (int j = 1; j <= bredd; j += 2)
    {
        if (i %2 == 0)
        {
            Console.Write($"O");
            if (j != bredd)
                Console.Write($"X");
        }
        else
        {
            Console.Write($"X");
            if (j != bredd)
                Console.Write($"O");
        }

    }
    Console.WriteLine("");
}
*/

using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

void ovning12()
{
    Console.Write("Bredd: ");
    int bredd = Convert.ToInt32(Console.ReadLine());
    Console.Write("Höjd: ");
    int hojd = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < hojd; i++)
    {
        for (int j = 0; j <bredd; j++)
        {
            if(i == 0 || i == hojd-1)
                Console.Write("X");
            else
            {
            if (j == 0 || j == bredd-1)
                    Console.Write("X");
                else if(j >0 || j < bredd-2)
                    Console.Write("-");

            }

        }
        Console.WriteLine("");
    }
}


/* ÖVNING 13
for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}
*/

/*ÖVNING 14
for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= i; j++)
    {
        for (int k = 1; k <= j; k++)
        {
            Console.Write(k);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/

/*// ÖVNING 15 - Gissa talet
Random random = new Random();
int rng = random.Next(1, 100);
bool gameOver = false;
bool reset = true;
int tries = 0;
int guess = 0;
bool canGuess = true;


while (!gameOver)
{
    if (canGuess)
    {
        if (reset)
        {
            Console.Clear();
            Console.WriteLine("Hej!, Gissa vilket tal jag tänker på mellan 1-100.");
            rng = random.Next(1, 100);
            tries = 0;
            reset = false;
        }
        string name = Console.ReadLine();

        bool isDigitPresent = name.Any(c => char.IsDigit(c));

        if (isDigitPresent)
        {
            guess = Convert.ToInt32(name);

            if (guess > rng)
            {
                Console.Clear();
                Console.WriteLine("För högt, Gissa igen!");
                tries++;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("För lågt, Gissa igen!");
                tries++;
            }
            if (guess == rng)
            {
                Console.Clear();
                Console.WriteLine("Du gissade rätt!!");
                Console.WriteLine($"Mitt nummer var: {rng}");
                Console.WriteLine($"Det tog dig {tries} försök att lista ut det.");
                Console.WriteLine("Vill du spela igen? Y / N ");
                canGuess = false;
                
            }
        }
        else
            Console.WriteLine("Mata in ett giltigt svar.");
    }
    else
    {
        string tryAgain = Console.ReadLine();
        if (tryAgain == "n" || tryAgain == "N")
            gameOver = true;
        if (tryAgain == "Y" || tryAgain == "y")
        {
            reset = true;
            canGuess = true;

        }
        if (tryAgain != "n" || tryAgain == "N" || tryAgain != "Y" || tryAgain != "y")
            Console.WriteLine("Mata in ett giltigt alternativ.");
    }
}
*/

/* ÖVNING 16
int totalSum = 0;
for (int i = 1; i <= 1000; i++)
{
    totalSum += i;
}
Console.WriteLine($"Totala summan av 1-1000 är: {totalSum}");
*/

/* ÖVNING 17
int counter = 0;
int prime = 2;
while (counter < 20)
{
    if (checkPrime(prime))
    {
        Console.Write($"{prime} ");
        counter++;
    }
    prime++;
}

bool checkPrime(int Number)
{
    int x = (int)Math.Floor(Math.Sqrt(Number));
    if (Number == 2) return true;

    for (int i = 2; i <= x; i++)
    {
        if (Number % i == 0) return false;
    }
    return true;
}
*/

/* ÖVNING 18
int tempRow = 1;
int tempRow2;
int row = 0;
int counter=1;
while (counter <= 20)
{
    for (int i = 0; i <= row; i++)
    {
        if(i == row)
        Console.WriteLine(row);
    }
    tempRow2 = tempRow;
    tempRow = row;
    row = tempRow2 + tempRow;

    counter++;
}
*/

/*ÖVNING 19
string tal = "";
bool shutDown = false;
double totalSum=0;
double counter = 0;
double medel = 0;

while (!shutDown)
{
    Console.Write("Mata in ett tal: ");
    tal = Console.ReadLine();

    if (tal == "")
    {
        shutDown = true;
        medel = totalSum / counter;
        Console.WriteLine($"Medelvärdet av alla inmatade tal är: {medel}");
    }

    bool isDigitPresent = tal.Any(c => char.IsDigit(c));

    if (isDigitPresent)
    {
        shutDown=false;
        totalSum += Convert.ToDouble(tal);
        Console.WriteLine($"Totala summan av inmatade tal är: {totalSum}");
        counter++;
    }
}
*/

/* ÖVNING 20
string input = "";
string tecken = "";
double number = 0;
double number2 = 0;
bool isDigitPresent = false;
bool firstNumber = true;
bool moveToTecken = false;
bool lastNumber = false;
bool printResult = false;
double result = 0;
bool end = false;

while (!end)
{
    if (firstNumber)
    {
        Console.Write("Mata in ett tal: ");
        input = Console.ReadLine();
        isDigitPresent = input.Any(c => char.IsDigit(c));
        if (isDigitPresent)
        {
            number = Convert.ToDouble(input);
            moveToTecken = true;
        }
    }
    if (moveToTecken)
    {
        firstNumber = false;
        Console.WriteLine("Mata in ett av följande tecken: +, -, /, *, %");
        Console.Write("Tecken: ");
        tecken = Console.ReadLine();
        if (tecken == "+" || tecken == "-" || tecken == "/" || tecken == "*" || tecken == "%")
            lastNumber = true;
    }
    if (lastNumber)
    {
        moveToTecken = false;
        Console.Write("Mata in ett till tal: ");
        input = Console.ReadLine();
        isDigitPresent = input.Any(c => char.IsDigit(c));
        if (isDigitPresent)
        {
            number2 = Convert.ToDouble(input);
            printResult = true;
        }
    }

    if (printResult)
    {
        lastNumber = false;
        if (tecken == "+")
            Console.WriteLine($"{number} + {number2} = {number + number2}");
        if (tecken == "-")
            Console.WriteLine($"{number} - {number2} = {number - number2}");
        if (tecken == "/")
            Console.WriteLine($"{number} / {number2} = {number / number2}");
        if (tecken == "*")
            Console.WriteLine($"{number} * {number2} = {number * number2}");
        if (tecken == "%")
            Console.WriteLine($"{number} % {number2} = {number % number2}");
        end = true; 
    }

}
*/

/* ÖVING 21
int counter = 1;
int row = 1;

while (counter <= 16)
{
    for (int i = 1; i <= row; i++)
    {
        if (i == row)
        {
            Console.WriteLine($"{row}");
            counter++;
        }
    }
    row *= 2;
}
*/

/* //ÖVNING 22 STEN SAX PÅSE
Random random = new Random();
int pcGuess = random.Next(1, 4);

int whoWon = 0;
int myScore = 0;
int pcScore = 0;

string userGuess = "";

bool resetChoice = true;
bool gameOver = false;
bool reset = true;
bool uSten = false, uPåse = false, uSax = false,
    pcSten = false, pcPåse = false, pcSax = false;

//Medan Gameover är falskt så körs spelet.
while (!gameOver)
{
    //Genererar datorns val
    pcGuess = random.Next(1, 4);

    //När du startar om spelet efter du har vunnit eller precis startat spelet så sätter den alla värden till sitt ursprungliga.
    if (reset)
    {
        Console.Clear();
        Console.WriteLine("Välkommen till Sten, Sax och Påse!");
        Console.WriteLine("");
        Console.WriteLine("Skriv Sten/R för att välja Sten.");
        Console.WriteLine("Skriv Sax/S för att välja Sax.");
        Console.WriteLine("Skriv Påse/P för att välja Påse.");
        Console.WriteLine("----------------------------------");

        whoWon = 0;
        reset = false;
        resetChoice = true;
    }

    //Kan användaren gissa eller inte.
    //Matar in användarens val
    userGuess = myGuess(userGuess);

    //Kör funktionerna för att omvandla användaren och datorns val
    userChoice(userGuess);
    pcChoice(pcGuess);

    //Kollar om spelaren har gjort ett giltigt val
    if (uPåse || uSten || uSax)
    {
        //När användaren gjort ett val körs funktionen för att se vem som vann.
        whoWon = ConvertGuessToResult(whoWon);

        //Programmet skrivet ut vad datorn valde efter att användaren gjort sitt val.
        if (pcSten)
            Console.WriteLine("Datorn valde: Sten.");
        if (pcPåse)
            Console.WriteLine("Datorn valde: Påse.");
        if (pcSax)
            Console.WriteLine("Datorn valde: Sax.");

        resetChoice = true;
    }
    else if (!uPåse && userGuess != "" || !uSten && userGuess != "" || !uSax  && userGuess != "")
    {
        //Om använder inte väljer något eller skriver fel så kommer de skrivas ut "Felaktigt val"
        Console.WriteLine("FELAKTIGT VAL!");
        Console.WriteLine("Du måste skriva Rock/R, Paper/P eller Scissor/S ");
        Console.WriteLine();

        //Reset bådas val. Främst för att datorn inte ska ha två val aktiva samtidigt
        resetChoice = true;
    }

    //Om användaren inte skriver något så stängs spelet av.
    if (userGuess == "")
    {
        gameOver = true;
        Console.WriteLine("Spelet stängs av.....");
    }

    //Kollar om man har vunnit/förlorat
    switch (whoWon)
    {
        case 1:
            resetChoice = true;
            myScore++;
            Console.WriteLine("");
            Console.WriteLine($"Grattis du vann!, Du: {myScore} | Datorn: {pcScore}");
            Console.WriteLine("----------------------------------");
            break;
        case 2:

            resetChoice = true;
            pcScore++;
            Console.WriteLine("");
            Console.WriteLine($"Datorn vann!, Du: {myScore} | Datorn: {pcScore}");
            Console.WriteLine("----------------------------------");
            break;
        case 3:
            resetChoice = true;
            Console.WriteLine("");
            Console.WriteLine("Oavgjort!, Gör ett nytt val.");
            Console.WriteLine("");
            break;
    }

    if (resetChoice)
    {
        uSten = false;
        uPåse = false;
        uSax = false;
        pcSten = false;
        pcPåse = false;
        pcSax = false;

        // Gör så att om man vunnit/förlorat en runda och en gör ett inaktivt val så skriver den inte ut den texten varje gång du gör ett felaktigt val.
        whoWon = 0;
    }

}

//Säger till användaren att mata in sitt val.
string myGuess(string guess)
{
    Console.Write("Mitt val: ");
    return guess = Console.ReadLine();
}

//Omvandlar datorn och användarens val till ett resultat.
int ConvertGuessToResult(int resultat)
{
    //Användaren vann
    if (uSten && pcSax || uPåse && pcSten || uSax && pcPåse)
        return whoWon = 1;
    //Datorn vann
    if (pcSten && uSax || pcPåse && uSten || pcSax && uPåse)
        return whoWon = 2;
    //Oavgjort
    return whoWon = 3;
}

//Här väljs användarens val.
bool userChoice(string user)
{
    //Kollar om användaren valde sten.
    if (user == "Sten" || user == "sten" || user == "R" || user == "r")
    {
        return uSten = true;
    }

    //Kollar om användaren valde påse.
    if (user == "Påse" || user == "påse" || user == "P" || user == "p")
    {
        return uPåse = true;
    }

    //Kollar om användaren valde sax.
    if (user == "Sax" || user == "sax" || user == "S" || user == "s")
    {
        return uSax = true;
    }

    //Spelaren gjorde inget val.
    return false;
}

//Här väljs datorns val
bool pcChoice(int pc)
{

    //Kollar om datorn valde sten.
    if (pc == 1)
    {
        return pcSten = true;
    }

    //Kollar om datorn valde påse.
    if (pc == 2)
    {
        return pcPåse = true;
    }

    //Kollar om datorn valde sax.
    if (pc == 3)
    {
        return pcSax = true;
    }

    //Bara där för att funktionen ska funka. Datorn kommer alltid välja något
    return false;

}
*/

//Varianter av rektanglar i olika mönster

/* //Variant A
for (int i = 1; i <= 4; i++)
{
   for (int j = 1; j <= 8; j++)
   {
       if(i == j)
       Console.Write('#');
       else
           Console.Write('-');
   }
   Console.WriteLine("");
}
*/

/* //Variant B
int Hashtag = 1;
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 8; j++)
    {
        if (j == Hashtag || j == Hashtag+4)
            Console.Write($"#");
        else
            Console.Write($"-");
    }
    Hashtag++;
    Console.WriteLine("");
}
*/

/* //Variant C
int Hashtag = 1;
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 8; j++)
    {
        if (j == Hashtag || j == Hashtag + 1)
            Console.Write($"#");
        else
            Console.Write($"-");
    }
    Hashtag+=2;
    Console.WriteLine("");
}
*/

/* //Variant D
int Hashtag = 3;
int fullRow = 3;
int width = 8;
int height = 4;
for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= width; j++)
    {
        if(i == fullRow)
            Console.Write($"#");
        else if (j == Hashtag || j == Hashtag + 3)
            Console.Write($"#");
        else
            Console.Write($"-");

        if (i == fullRow && j == width)
            fullRow += 3;
    }
    Console.WriteLine("");
}
*/

/* //Variant E
int Hashtag = 1;
int Hashtag2 = 5;
int width = 8;
int height = 16;
bool countup = true;
bool countdown = true;
for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= width; j++)
    {
        if (j == Hashtag || j == Hashtag2)
            Console.Write($"#");
        else
            Console.Write($"-");
    }
    if (Hashtag == width)
        countup = false;
    if (Hashtag == 1)
        countup = true;

    if(Hashtag2 == width)
        countdown = true;
    if (Hashtag2 == 1)
        countdown = false;

    if (countup)
        Hashtag++;
    else
        Hashtag--;

    if (countdown)
        Hashtag2--;
    else
        Hashtag2++;

    Console.WriteLine("");
}
*/

/* //Variant F
int Hashtag = 1;
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 4; j++)
    {
        if (j == Hashtag || j == Hashtag + 2)
            Console.Write($"#");
        else
            Console.Write($"-");
    }
    if (i % 2 == 0)
        Hashtag--;
    else
        Hashtag++;

    Console.WriteLine("");
}
*/

/* //Variant G
int Hashtag = 1;
int width = 6;
int height = 4;
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= width; j++)
    {
        if (j <= width/2 && i != height)
            Console.Write($"#");
        else
            Console.Write($"-");
        
    }
    Hashtag++;
    Console.WriteLine("");
}
*/

/* //Variant H
int Hashtag = 3;
int width = 7;
bool countup = true;
for (int i = 1; i <= 25; i++)
{
    for (int j = 1; j <= width; j++)
    {
        if (((j == width - 1 || j == width) && Hashtag < (width - 2)))
            Console.Write($"#");
        else if (j == Hashtag)
            Console.Write($"#");
        else
            Console.Write($"-");
    }

    if (Hashtag == width)
        countup = false;
    if (Hashtag == 1)
        countup = true;

    if (countup)
        Hashtag++;
    else
        Hashtag--;

    Console.WriteLine("");
}
*/

/* //Variant I
int Hashtag = 3;
int skipRow = 2;
int width = 5;
int height =16;
int counter = 1;
for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= width; j++)
    {
        if (j == Hashtag && i != skipRow)
            Console.Write($"#");
        else
            Console.Write($"-");

        if ((i == skipRow && j == width) && counter == 1)
        {
            skipRow += 3;
            counter = 2;
        }
        if ((i == skipRow && j == width) && counter == 2)
        {
            skipRow += 2;
            counter = 1;
        }

    }
    Console.WriteLine("");
}
*/

/* //Variant J
int width = 5;
int height = 16;
int Hashtag = 1;
int Hashtag2 = width;
bool countup = true;
bool countdown = true;
for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= width; j++)
    {
        if (Hashtag == Hashtag2 && j == Hashtag)
            Console.Write($"o");
        else if (j == Hashtag || j == Hashtag2)
            Console.Write($"#");
        else
            Console.Write($"-");

    }
    if (Hashtag == width)
        countup = false;
    if (Hashtag == 1)
        countup = true;

    if (Hashtag2 == width)
        countdown = true;
    if (Hashtag2 == 1)
        countdown = false;

    if (countup)
        Hashtag++;
    else
        Hashtag--;

    if (countdown)
        Hashtag2--;
    else
        Hashtag2++;

    Console.WriteLine("");
}
*/

/* //Variant K
int Hashtag = 1;
int fullRow = 4;
int width = 16;
int height = 8;
for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= width; j++)
    {
        if(i != fullRow && i != fullRow-1 )
        {
            if(j == Hashtag && j <= width/2)
            {
                Console.Write($"##");
                Hashtag += 2;
            }
            else if (j != Hashtag && j <= width / 2)
                Console.Write($"--");
        }

        if (i == fullRow)
            Console.Write($"#");

        if (i == fullRow - 1)
        {
            if (j <= (width / 2) - 2)
                Console.Write("W");
            else Console.Write("~");
        }

        if (i == fullRow && j == width)
            fullRow += 4;
    }
    Hashtag =1;
    Console.WriteLine("");
}
*/


void ovning24()
{
    string helloWorld = "Hello World";

    for (int i = helloWorld.Length - 1; i >= 0; i--)
    {
        helloWorld.Replace(helloWorld.Substring(0, i), helloWorld.Substring(i + 1));
        Console.Write(helloWorld[i]);
    }

    Console.WriteLine();
}

void ovning25()
{

    string helloWorld = "Hello World";
    for (int i = 0; i < helloWorld.Length; i++)
    {
        if (helloWorld[i] == 'o')
            Console.Write('x');
        else
            Console.Write(helloWorld[i]);
        //Console.WriteLine(helloWorld.Replace("o", "x"));
    }
}

void ovning26()
{
    string helloWorld = "Hello World";
    for (int i = 0; i < helloWorld.Length; i++)
    {
        if (i % 2 == 1)
            Console.Write("X");
        else
            Console.Write(helloWorld[i]);
    }
}

void ovning27()
{
    string helloWorld = "Hello World";
    for (int i = 0; i < helloWorld.Length; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write(helloWorld[j]);
        }
        Console.WriteLine();
    }
}

void ovning28()
{
    Console.Write("Mata in en text: ");
    string text = Console.ReadLine();
    bool isnumber;
    int amount;

    do
    {
        Console.Write("Hur många tecken vill du se?: ");
        isnumber = int.TryParse(Console.ReadLine(), out amount);
    } while (!isnumber || amount > text.Length);
    for (int j = 0; j < amount; j++)
        Console.Write(text[j]);

}

void ovning29()
{
    Console.Write("Mata in en text: ");
    string text = Console.ReadLine();

    Console.Write("Mata in en bokstav: ");
    char letter = Console.ReadKey().KeyChar;
    Console.WriteLine();

    for (int i = 0; i < text.Length; i++)
    {
        if (letter == text[i])
            Console.ForegroundColor = ConsoleColor.Red;
        else
            Console.ForegroundColor = ConsoleColor.Gray;

        Console.Write(text[i]);
    }
}

void ovning30()
{
    Console.Write("Mata in en text: ");
    string text = Console.ReadLine();
    int start;
    int end;
    Console.Write("Välj startindex: ");
    bool isnumber = int.TryParse(Console.ReadLine(), out start);
    Console.Write("Välj stopindex: ");
    isnumber = int.TryParse(Console.ReadLine(), out end);
    Console.WriteLine();

    if (isnumber)
        for (int i = 0; i < text.Length; i++)
        {
            if (i >= start && i <= end)
                //Console.Write($"Du har valt att skriva ut: {text[i]}.");
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.White;

            Console.Write(text[i]);

        }
}

void ovning31()
{
    Console.Write("Mata in en text: ");
    //string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
    string text = Console.ReadLine();
    Console.Write("Välj en bokstav från din text: ");
    string letter = Console.ReadLine();
    Console.WriteLine();
    int start = -5;
    int end = -6;

    for (int i = 0; i < text.Length; i++)
    {
        if (i != end)
            if (letter[0] == text[i])
            {
                start = i;
                for (int j = start + 1; j < text.Length; j++)
                {
                    if (letter[0] == text[j])
                    {
                        end = j;
                        break;

                    }
                }
            }

        if (i >= start && i <= end)
            Console.ForegroundColor = ConsoleColor.Red;
        else
            Console.ForegroundColor = ConsoleColor.White;

        Console.Write(text[i]);
    }
}

void ovning32()
{
    Console.Write("Mata in en text: ");
    string text = Console.ReadLine();
    text = text.ToUpper();

    char[] vokals = { 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };
    int counter = 0;
    int[] howmanyvokals = new int[9];
    foreach (char c in vokals)
    {

        for (int i = 0; i < text.Length; i++)
        {
            if (c == text[i])
            {
                howmanyvokals[counter]++;
            }
            //if (vokals.Contains(text[i])) counter++;

        }
        if (howmanyvokals[counter] > 0)
            Console.WriteLine($"{c}: {howmanyvokals[counter]}");
        counter++;
    }
}

void ovning33()
{
    string number;
    string[] numberText = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

    Console.WriteLine("Mata in siffra: ");
    number = Console.ReadLine();

    for (int i = 0; i < number.Length; i++)
    {
        int num = int.Parse(number[i].ToString());
        Console.Write(numberText[num]);

        if (i < number.Length - 1)
            Console.Write('-');
    }
}

void ovning34()
{
    string[] words = new string[7];

    for (int i = 0; i < 7; i++)
    {
        Console.WriteLine("Skriv in ett ord: ");
        words[i] = Console.ReadLine();
    }
    for (int i = words.Length - 1; i >= 0; i--)
        Console.Write($"{words[i]} ");
}

void ovning35()
{
    List<string> allWords = new List<string>();
    string[] array = allWords.ToArray();
    bool infinite = true;
    int wordcounter;

    while (infinite)
    {
        Console.WriteLine("Skriv ett ord: ");
        allWords.Add(Console.ReadLine());
        wordcounter = allWords.Count;
        if (allWords.Count >= 10)
            Console.WriteLine(allWords[wordcounter - 10]);
        else
            Console.WriteLine("Du har inte skrivit 10 ord än.");
    }
}

void ovning36()
{
    Random moveCursor = new Random();
    int CursorlocationY;
    int[] number = new int[10];
    Console.CursorVisible = false;

    for (int i = 0; i < number.Length; i++)
    {
        Console.WriteLine(number[i]);
    }

    while (true)
    {
        Thread.Sleep(1000);
        Console.SetCursorPosition(0, 0);

        CursorlocationY = moveCursor.Next(0, 10);
        number[CursorlocationY]++;

        for (int i = 0; i < 10; i++)
        {
            if (i == CursorlocationY)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(number[i]);
        }
        Console.SetCursorPosition(0, CursorlocationY);
    }
}

void ovning38()
{
    int direction = 0;
    Random random = new Random();
    var fruitX = random.Next(1, 19);
    var fruitY = random.Next(1, 8);

    int Score = 0;
    ConsoleKey key;
    int xPos = 5;
    int yPos = 5;
    Console.CursorVisible = false;

    //WALLS
    string[,] Grid = new string[28, 116]{
                                {"X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," ","X","X","X"," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," ","X","X","X","X","X"," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," ","X","X","X","X","X","X","X"," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," ","X","X","X","X","X","X","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," ","X","X","X","X","X","X","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," ","X","X","X","X","X"," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," ","X","X","X"," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X","X","X"," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X","X","X","X","X"," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X","X","X"," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," ","X","X","X"," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," ","X","X","X","X","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," ","X","X","X","X","X","X","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," ","X","X","X","X","X","X","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," ","X","X","X","X","X","X","X"," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," ","X","X","X","X","X"," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," ","X","X","X"," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","X",},
                                {"X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X",},


                            };
    //PRINTING WALLS
    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < Grid.GetLength(0); i++)
    {
        for (int j = 0; j < Grid.GetLength(1); j++)
        {
            Console.Write($"{Grid[i, j]}");
        }
        Console.WriteLine();
    }

    //Console.SetCursorPosition(fruitX, fruitY);
    //Console.WriteLine("@");

    if (xPos == fruitX && yPos == fruitY)
    {
        Score++;
        fruitX = random.Next(1, 19);
        fruitY = random.Next(1, 9);
        Console.SetCursorPosition(fruitX, fruitY);
        Console.WriteLine("@");
    }

    // MOVEMENT
    do
    {
        key = Console.ReadKey(true).Key;

        while (!Console.KeyAvailable)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (direction == 1)
                        break;
                    else
                        direction = 0;
                    break;
                case ConsoleKey.DownArrow:
                    if (direction == 0)
                        break;
                    else
                        direction = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    if (direction == 3)
                        break;
                    else
                        direction = 2;
                    break;
                case ConsoleKey.RightArrow:
                    if (direction == 2)
                        break;
                    else
                        direction = 3;
                    break;
            }

            if (direction == 0)
            {
                if (Grid.GetValue(yPos - 1, xPos) == " ")
                {
                    Console.Write(" ");
                    yPos--;
                    Console.SetCursorPosition(xPos, yPos);
                    //Console.WriteLine(Grid.GetValue(yPos, xPos));
                    Console.WriteLine("O");
                    Console.SetCursorPosition(xPos, yPos);
                }

                if (Grid.GetValue(yPos, xPos) == "X")
                    Lose();
            }
            if (direction == 1)
            {
                if (Grid.GetValue(yPos + 1, xPos) == " ")
                {

                    Console.Write(" ");
                    yPos++;
                    Console.SetCursorPosition(xPos, yPos);
                    //Console.WriteLine(Grid.GetValue(yPos, xPos));
                    Console.WriteLine("O");
                    Console.SetCursorPosition(xPos, yPos);
                }
                else
                    Lose();
            }
            if (direction == 2)
            {
                if (Grid.GetValue(yPos, xPos - 1) == " ")
                {
                    Console.Write(" ");
                    xPos--;
                    Console.SetCursorPosition(xPos, yPos);
                    //Console.WriteLine(Grid.GetValue(yPos, xPos));
                    Console.WriteLine("O");
                    Console.SetCursorPosition(xPos, yPos);
                }
                else
                    Lose();
            }
            if (direction == 3)
            {
                if (Grid.GetValue(yPos, xPos + 1) == " ")
                {
                    Console.Write(" ");
                    xPos++;
                    Console.SetCursorPosition(xPos, yPos);
                    //Console.WriteLine(Grid.GetValue(yPos, xPos));
                    Console.WriteLine("O");
                    Console.SetCursorPosition(xPos, yPos);

                }
                else
                    Lose();
            }


            Thread.Sleep(500);

        }
        void Lose()
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("YOU LOSE!");
            Thread.Sleep(10000);
        }
        Console.SetCursorPosition(xPos, yPos);

    } while (key != ConsoleKey.Escape);

}

void ovning39()
{
    ConsoleKey keypressed;
    //Sätter start riktning till höger.
    string direction = "Right";

    //Svans längd
    int nTail = 4;

    //Gameover är inte sant. spelet kommer köras.
    bool gameover = false;
    bool reset = false;
    bool pressed = false;

    //Skapar ett random tal till berry.
    Random randomnummer = new Random();
    int berryX = randomnummer.Next(6, 113);
    int berryY = randomnummer.Next(4, 26);

    //Skapar en timer
    DateTime Timer = DateTime.Now;
    DateTime Timer2 = DateTime.Now;

    //Skapar svansen X och Y värde
    int[] TailX = new int[100];
    int[] TailY = new int[100];

    Console.CursorVisible = false;

    //skapar variablar för positionerna för huvudet och svansen.
    int headX = 10;
    int headY = 8;
    int pretempX = headX, tempX = headX;
    int pretempY = headY, tempY = headY;
    //Skapar score variabel.
    int Score = 0;
    int x = 0;
    int y = 0;

    //Skapar och printar väggarna.
    Drawborder();
    Console.ForegroundColor = ConsoleColor.Gray;

    /*
    string[,] Grid = new string[5, 5]{
        {" "," ","X"," "," ",},
        {" ","X","X","X"," ",},
        {"X","X","X","X","X",},
        {" ","X","X","X"," ",},
        {" "," ","X"," "," ",}, };
    //Skapar Föremål att krascha med
    for (int m = 0; m < 2; m++)
    {
        for (int k = 0; k < 4; k++)
        {
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                Console.SetCursorPosition(20 + x, 6 + i + y);
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Console.Write($"{Grid[i, j]}");
                }
                Console.WriteLine();
            }
            x += 25;
            if (k == 3)
            {
                x = 0;
            }
        }
        y += 13;
    }
    //reset x och y
    x = 0;
    y = 0;
    for (int k = 0; k < 3; k++)
    {
        for (int i = 0; i < Grid.GetLength(0); i++)
        {
            Console.SetCursorPosition(33 + x, 12 + i);
            for (int j = 0; j < Grid.GetLength(1); j++)
            {
                Console.Write($"{Grid[i, j]}");
            }
            Console.WriteLine();
        }
        x += 25;
    }
    */

    //SPELET MAIN KOD
    while (!gameover)
    {
        //Det här händer när spelet startar om
        if (reset)
        {
            reset = false;
            direction = "Right";

            for (int i = 0; i < nTail; i++)
            {
                Console.SetCursorPosition(TailX[i], TailY[i]);
                Console.WriteLine(" ");
            }

            Score = 0;
            nTail = 4;
            headX = 10;
            headY = 8;
            tempX = 0;
            tempY = 0;
            for (int i = 0; i < nTail; i++)
            {

                TailX[i] = 0;
                TailY[i] = 0;
            }
            pretempX = 0;
            pretempY = 0;
            x = 0;
            y = 0;
            berryX = randomnummer.Next(6, 113);
            berryY = randomnummer.Next(4, 26);
            Console.Clear();
            Drawborder();

        }

        //Kollar om man nuddar någon av väggarna
        if (headX < 6 || headX > 112 || headY < 4 || headY > 25)
            gameover = true;

        //Om man "äter" ett bär så flyttar den postion och svansen och score plusas med 1
        if (headX == berryX && headY == berryY)
        {
            Score++;
            nTail++;
            berryX = randomnummer.Next(6, 113);
            berryY = randomnummer.Next(4, 26);
        }

        //Lagrar pretemp med första svansbiten position. Så att de andra svansbitarna hamnar på rätt ställe
        pretempX = TailX[0];
        pretempY = TailY[0];
        //Gör så att svansen alltid följer efter huvudet
        TailX[0] = headX;
        TailY[0] = headY;

        //Lägger till "svansen"
        for (int i = 1; i <= nTail; i++)
        {
            //Sätter position för alla svansbitar
            tempX = TailX[i];
            tempY = TailY[i];
            TailX[i] = pretempX;
            TailY[i] = pretempY;
            pretempX = tempX;
            pretempY = tempY;

            //Printar svansen
            if (TailX[i] > 1 && TailY[i] > 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(TailX[i], TailY[i]);
                Console.Write("#");
            }

            if (berryX == TailX[i] && berryY == TailY[i])
            {
                berryX = randomnummer.Next(6, 113);
                berryY = randomnummer.Next(4, 26);
            }
            if (TailX[i] == headX && TailY[i] == headY)
                gameover = true;

            Console.SetCursorPosition(pretempX, pretempY);
            Console.WriteLine(" ");

        }

        Timer = DateTime.Now;

        //Sätter att ingen knapp är nertryckt
        pressed = false;

        while (true)
        {
            Console.SetCursorPosition(pretempX, pretempY);
            Console.WriteLine(" ");
            //När det gått 0.2 bryts while loopen och all annan kod körs.
            Timer2 = DateTime.Now;
            if (Timer2.Subtract(Timer).TotalMilliseconds > 200) { break; }

            //Kollar om man fortfarande kan trycka på knappar
            if (Console.KeyAvailable)
            {
                //Kollar vilken knapp som tryckts
                keypressed = Console.ReadKey(true).Key;
                switch (keypressed)
                {
                    case ConsoleKey.UpArrow:
                        if (direction == "Down" || pressed == true) break;
                        pressed = true;
                        direction = "Up"; break;
                    case ConsoleKey.DownArrow:
                        if (direction == "Up" || pressed == true) break;
                        pressed = true;
                        direction = "Down"; break;
                    case ConsoleKey.LeftArrow:
                        if (direction == "Right" || pressed == true) break;
                        pressed = true;
                        direction = "Left"; break;
                    case ConsoleKey.RightArrow:
                        if (direction == "Left" || pressed == true) break;
                        pressed = true;
                        direction = "Right"; break;
                }
            }
        }

        //Printar score
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(6, 2);
        Console.Write("Score: " + Score);
        //Printar bäret
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(berryX, berryY);
        Console.Write("@");

        Console.ForegroundColor = ConsoleColor.Blue;
        //Väljer riktning på ormen & Printar huvudet
        switch (direction)
        {
            case "Up":
                headY--;
                Console.SetCursorPosition(headX, headY);
                Console.WriteLine("^");
                break;
            case "Down":
                headY++;
                Console.SetCursorPosition(headX, headY);
                Console.WriteLine("v");
                break;
            case "Left":
                headX--;
                Console.SetCursorPosition(headX, headY);
                Console.WriteLine("<");
                break;
            case "Right":
                headX++;
                Console.SetCursorPosition(headX, headY);
                Console.WriteLine(">");
                break;
        }

        //När spelet är över händer de här!
        while (gameover)
        {
            //Game over text
            Console.SetCursorPosition(headX, headY);
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(54, 11);
            Console.Write("YOU LOST!");
            Console.SetCursorPosition(45, 12);
            Console.Write("Press R to Restart the game.");

            //Printar score för jag har en bug som jag inte orkar lösa. Se rad 1652.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(6, 2);
            Console.Write("Score: " + Score);

            keypressed = Console.ReadKey(true).Key;

            if (keypressed == ConsoleKey.R)
            {
                gameover = false;
                reset = true;
            }
        }

    }

    //funktion för att rita väggarna
    void Drawborder()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        for (int i = 3; i < 27; i++)
        {
            Console.SetCursorPosition(5, i);
            Console.WriteLine("X");
        }
        for (int i = 3; i < 27; i++)
        {
            Console.SetCursorPosition(114, i);
            Console.WriteLine("X");
        }
        for (int i = 6; i < 114; i++)
        {
            Console.SetCursorPosition(i, 3);
            Console.Write("X");
        }
        for (int i = 6; i < 114; i++)
        {
            Console.SetCursorPosition(i, 26);
            Console.Write("X");
        }
    }
}

void ovning40()
{
    string text = "Kopiera all text i denna uppgiften och lägg in i en sträng-variabel. " +
                  "Skriv ett program som visar texten som en rullande text med 10 teckens bredd på översta raden i din konsolapp. " +
                  "Man ska alltså se endast 10 tecken åt gången, men texten ska “rulla” fram från höger till vänster, så att man kan läsa hela texten.. " +
                  "Hitta en lagom hastighet att uppdatera texten så att det blir behagligt att läsa. När hela texten rullat förbi ska den börja om igen.";

    int nextLetter = 0;
    int countdown = 10;
    int speed = 120;
    int cursorLocation = 9;
    int showLetter = 1;

    Console.CursorVisible = false;
    for (int i = 0; i < text.Length; i++)
    {
        Thread.Sleep(speed);

        if (nextLetter < text.Length - 10)
        {
            Console.SetCursorPosition(cursorLocation, 0);
            Console.Write(text.Substring(0 + nextLetter, showLetter));

            if (showLetter < 10)
                showLetter++;
            if (cursorLocation > 0)
                cursorLocation--;
            else
                nextLetter++;

            if (nextLetter == text.Length - 10)
                i = nextLetter - 1;
        }
        else
        {
            Console.SetCursorPosition(countdown, 0);
            Console.WriteLine(" ");
            Console.SetCursorPosition(0, 0);
            Console.Write(text.Substring(i, countdown));
            countdown--;

            if (countdown == 0)
            {
                i = -1;
                nextLetter = 0;
                countdown = 10;
                cursorLocation = 10;
                showLetter = 0;
            }
        }
    }

}

void ovning41()
{
    Console.Write("Mata in ett tal: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Mata in ett tal: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Största talet av {x} och {y} är: {Math.Max(x, y)}");
}

void ovning42()
{
    Console.Write("Mata in längd i cm: ");
    double x = Double.Parse(Console.ReadLine());
    double x2 = x / 100;
    Console.Write("Mata in vikt: ");
    double y = Double.Parse(Console.ReadLine());
    double y2 = y / Math.Pow(x2, 2);
    Console.WriteLine($"BMI för längd: {x}cm och vikt: {y}kg är: {Math.Round(y2, 2)}");
}

void ovning43()
{

    Console.Write("Bitar: ");
    uint x;
    bool bitar = uint.TryParse(Console.ReadLine(), out x);
    Console.WriteLine(Math.Pow(2, x) - 1);
}

void ovning44()
{
    Console.Write("Mata in längd i cm: ");
    double katet1 = Double.Parse(Console.ReadLine());
    Console.Write("Mata in bredd i cm: ");
    double katet2 = Double.Parse(Console.ReadLine());
    double pythagoras = Math.Sqrt((Math.Pow(katet1, 2) + Math.Pow(katet2, 2)));
    Console.WriteLine($"Diagonalen är: {pythagoras}");

}

void ovning45()
{
    ConsoleKey key;
    int tal = 5;
    Console.Write(tal);
    do
    {
        key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.UpArrow && tal < 9)
            tal++;
        if (key == ConsoleKey.DownArrow && tal > 0)
            tal--;
        Console.SetCursorPosition(0, 0);
        Console.Write(tal);

    } while (key != ConsoleKey.Escape);

}

void ovning46()
{
    Console.Write("Skriv in ditt namn: ");
    string namn = Console.ReadLine();
    Console.Write($"Hej {namn.Trim().Replace(" ", "")}!");
}

void ovning47()
{
    Console.Write("Skriv ditt namn och efternamn: ");
    string namnEfternamn = Console.ReadLine();
    string[] användare = namnEfternamn.Split(' ');
    Console.WriteLine($"Förnamn: {användare[0]}");
    Console.Write($"Efternamn: {användare[1]}");
}

void ovning48()
{
    Console.Write("Skriv en mening med fler än ett ord: ");
    string mening = Console.ReadLine().ToLower();
    string[] användare = mening.Split(" ");
    Array.Reverse(användare, 0, användare.Length);

    användare[0] = användare[0].ToUpper().Remove(1, användare[0].Length - 1) + användare[0].Substring(1);
    Console.Write(string.Join(" ", användare));
}

void ovning49()
{
    while (true)
    {
        string input;
        Console.WriteLine("Skriv in tal och tecken, t ex 3 + 4: ");
        input = Console.ReadLine();

        bool isLetterPresent = input.Any(c => char.IsLetter(c));

        if (!isLetterPresent)
        {
            string[] allaTal = input.Split(" ");
            double tal1 = Convert.ToDouble(allaTal[0]);
            string tecken = allaTal[1];
            double tal2 = Convert.ToDouble(allaTal[2]);

            if (tecken == "+")
                Console.WriteLine($"Summan av att ditt tal är: {tal1 + tal2}");
            if (tecken == "-")
                Console.WriteLine($"Differensen av att ditt tal är: {tal1 - tal2}");
            if (tecken == "*")
                Console.WriteLine($"Produkten av att ditt tal är: {tal1 * tal2}");
            if (tecken == "/")
                Console.WriteLine($"Kvoten av att ditt tal är: {tal1 / tal2}");
        }
    }
}

void ovning50()
{
    Console.Write("Skriv in en text rad: ");
    string mening = Console.ReadLine();
    Console.WriteLine(mening.Replace(" ", "_"));
}

void ovning51()
{
    Console.Write("Skriv in en text rad: ");
    string mening = Console.ReadLine().ToLower();
    string[] CamelCase = mening.Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries);

    for (int i = 1; i < CamelCase.Length; i++)
        CamelCase[i] = CamelCase[i].ToUpper().Remove(1, CamelCase[i].Length - 1) + CamelCase[i].Substring(1);
    foreach (string word in CamelCase)
        Console.Write(word);
}

void ovning52()
{
    int[] number = new int[10];
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Mata in tal#{i + 1}: ");
        bool isDigit = Int32.TryParse(Console.ReadLine(), out number[i]);
        if (!isDigit)
            i--;
        Console.Clear();
    }
    Array.Sort(number);

    for (int j = 0; j < number.Length; j++)
    {
        if (j < 9)
            Console.WriteLine($"Tal {j + 1}: {number[j].ToString().PadLeft(10)}");
        else
            Console.WriteLine($"Tal {j + 1}: {number[j].ToString().PadLeft(9)}");
    }
}

void ovning53()
{
    Console.WriteLine("Mata in siffror. Separerar dem med ,");

    while (true)
    {
        Console.Write("Siffror: ");
        string text = Console.ReadLine();
        bool isLetterPresent = text.Any(c => char.IsLetter(c));

        if (Regex.IsMatch(text, "[^0-9]$"))
        {
            text = text.Remove(text.Length - 1);
        }

        if (!isLetterPresent)
        {
            string[] allaTal = text.Split(",");
            int[] numbers = Array.ConvertAll(allaTal, s => int.Parse(s));
            Array.Sort(numbers);

            for (int j = 0; j < numbers.Length; j++)
            {
                if (j < 9)
                    Console.WriteLine($"{j + 1}: {numbers[j].ToString().PadLeft(10)}");
                else
                    Console.WriteLine($"{j + 1}: {numbers[j].ToString().PadLeft(9)}");
            }
            break;
        }
    }
}

void ovning54()
{
    string[] names = { "Mikael Eriksson","Paulina Jonsson","Ioannis Anastasiadis","Paul Pogba", "Maria Pusic", "Fredrik Johansson", "Joel Blomberg",
        "Ba Hoang", "Johan Melin", "Erik Bergman", "Marie Johansson","Johan Lange","Johannes Nelsen" };

    Console.Write("Sök på namnsträng: ");
    string search = Console.ReadLine();

    for (int i = 0; i < names.Length; i++)
    {
        if (names[i].Contains(search, StringComparison.OrdinalIgnoreCase))
        {
            for (int j = 0; j < names[i].Length; j++)
            {
                if (names[i].Substring(j, search.Length).Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write(names[i].Substring(0, j));
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(names[i].Substring(j, search.Length));
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(names[i].Substring(j + search.Length, names[i].Length - (j + search.Length)));
                    break;
                }
            }
        }
    }
}

void ovning55()
{
    Console.WriteLine("Skriv en text, helst med åäö: ");
    string text = Console.ReadLine();
    string[] words = text.Split(" ");

    for (int i = 0; i < words.Length; i++)
    {
        words[i] = words[i].Replace("å", "a");
        words[i] = words[i].Replace("ä", "a");
        words[i] = words[i].Replace("ö", "o");
    }
    Console.Write(string.Join(" ", words));
}

void ovning56()
{
    FirstAndLastName("Mikael", "Eriksson");

    void FirstAndLastName(string firstName, string lastName)
    {
        Console.WriteLine($"{firstName} {lastName}");
    }
}

void ovning57()
{
    string fullName = FirstAndLastName("Mikael", "Eriksson");
    Console.WriteLine(fullName);

    string FirstAndLastName(string firstName, string lastName)
    {
        return firstName + " " + lastName;
    }
}

void ovning58()
{
    Console.WriteLine(FullMathExpression(3, 5));

    string FullMathExpression(int firstNumber, int lastNumber)
    {
        return $"{firstNumber} * {lastNumber} = {firstNumber * lastNumber}";
    }
}

void ovning58v2()
{
    Console.Write("Skriv ett tal: ");
    int tal = Convert.ToInt32(Console.ReadLine());
    MultiplicationTable(tal);

    void MultiplicationTable(int number)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{tal} * {i} = {tal * i}");
        }
    }
}

void ovning59()
{

    Console.Write("Skriv in en mening: ");
    string sentence = Console.ReadLine();
    string[] allWordsFromSentence = sentence.Split(" ");

    for (int i = 0; i < allWordsFromSentence.Length; i++)
    {
        allWordsFromSentence[i] = FirstLetterToUpperCase(allWordsFromSentence[i]);

    }
    Console.Write(string.Join(" ", allWordsFromSentence));

    string FirstLetterToUpperCase(string inputText)
    {
        return inputText.ToUpper().Remove(1, inputText.Length - 1) + inputText.Substring(1, inputText.Length - 1);
    }


}

void ovning59v2()
{

    Console.Write("Skriv in en mening: ");
    string sentence = Console.ReadLine();

    FirstWordInUpperCaseOrAllWords(sentence, false);
    Console.WriteLine();
    FirstWordInUpperCaseOrAllWords(sentence, true);


    void FirstWordInUpperCaseOrAllWords(string inputText, bool OnlyFirstWord)
    {
        string[] allWordsFromSentence = inputText.Split(" ");

        if (!OnlyFirstWord)
        {
            allWordsFromSentence[0] = FirstLetterToUpperCase(allWordsFromSentence[0]);
            Console.WriteLine(string.Join(" ", allWordsFromSentence));
        }
        else
        {
            for (int i = 0; i < allWordsFromSentence.Length; i++)
            {
                allWordsFromSentence[i] = allWordsFromSentence[i].ToUpper().Remove(1, allWordsFromSentence[i].Length - 1) + allWordsFromSentence[i].Substring(1, allWordsFromSentence[i].Length - 1);
            }
            Console.Write(String.Join(" ", allWordsFromSentence));
        }

    }
}

string FirstLetterToUpperCase(string inputText)
{
    return inputText.ToUpper().Remove(1, inputText.Length - 1) + inputText.Substring(1, inputText.Length - 1);
}

void ovning60()
{
    Random rng = new Random();
    int xPosition, yPosition;
    Console.CursorVisible = false;
    char key;

    do
    {
        key = Console.ReadKey(true).KeyChar;
        while (!Console.KeyAvailable)
        {
            xPosition = rng.Next(1, Console.WindowWidth - 5);
            yPosition = rng.Next(1, Console.WindowHeight - 5);
            RandomCordinate(xPosition, yPosition, key);
            Thread.Sleep(100);
        }
    } while (key != 'Q');


    void RandomCordinate(int xPos, int yPos, char letter = 'X')
    {
        Console.SetCursorPosition(xPos, yPos);
        Console.WriteLine(letter);
    }
}

void ovning61()
{
    Random rng = new Random();
    int xPosition;
    int yPosition;
    int sizeWidth;
    int sizeHeight;

    while (true)
    {
        xPosition = rng.Next(1, Console.WindowWidth - 5);
        yPosition = rng.Next(1, Console.WindowHeight - 5);
        sizeWidth = rng.Next(3,10);
        sizeHeight = rng.Next(3,10);
        DrawBox(sizeWidth, sizeHeight, xPosition, yPosition);
        Thread.Sleep(2000);
    }

    void DrawBox(int width, int height, int xPos, int yPos)
    {
        for (int i = 0; i < height; i++)
        {
            Console.SetCursorPosition(xPosition, yPosition + i);
            for (int j = 0; j < width; j++)
            {
                if (i == 0 || i == height - 1)
                    Console.Write("X");
                else
                {
                    if (j == 0 || j == width - 1)
                        Console.Write("X");
                    else if (j > 0 || j < width - 2)
                        Console.Write("-");
                }
            }
            Console.WriteLine("");
        }
    }
}

void ovning62()
{
    Console.Write("Mata in valfritt ord: ");
    string word = Console.ReadLine();
    Console.Write("Mata in valfritt tal: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SizeMatter(word,number));

    bool SizeMatter(string text, int number)
    {
        if (text.Length > number)
            return true;
        return false;
    }
}

void ovning63()
{
    string[] cities = { "Stockholm", "Göteborg", "Motala" };
    Console.Write("Mata in din Join symbol: ");
    string myDivider = Console.ReadLine();

    string CitiesJoined = Join(myDivider, cities);
    Console.WriteLine(CitiesJoined);

    string Join(string divider, params string[] words)
    {
        string myJoin = divider;
        string CitiedJoined = String.Empty;

        for (int i = 0; i < words.Length; i++)
        {
            if (i < words.Length - 1)
                CitiedJoined += words[i] + myJoin;
            else
                CitiedJoined += words[i];
        }
        return CitiedJoined;
    }
}

void ovning64()
{
    double result = ReturnMedelVarde(1, 3, 8, 2);
    Console.WriteLine(result);

    double ReturnMedelVarde (params int[] number)
    {
        double sumOfNumbers = 0;
        double average = 0;

        for (int i = 0; i < number.Length; i++)
        {
            sumOfNumbers += Convert.ToDouble(number[i]);
        }
        average = sumOfNumbers / number.Length;
        return average;
    }
}

void ovning65()
{
    Console.Write("Mata in valfritt tal: ");
    string nummer = Console.ReadLine();

    for (int i = 0; i < NumberToWords(nummer).Length; i++)
    {
        Console.Write(NumberToWords(nummer)[i]);
    }

    string[] NumberToWords(string inputNumber)
    {

        string[] numberText = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
        string[] newString = new string[inputNumber.Length];

        for (int i = 0; i < inputNumber.Length; i++)
        {
            int num = int.Parse(inputNumber[i].ToString());
            newString[i] = (numberText[num]);
        }

        return newString;
    }

}



ovning54();