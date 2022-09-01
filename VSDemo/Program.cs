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

/* ÖVNING 12
Console.Write("Bredd: ");
int bredd = Convert.ToInt32(Console.ReadLine());
Console.Write("Höjd: ");
int hojd = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= hojd; i++)
{
    for (int j = 1; j <= bredd; j++)
    {
        if (i == 1 || i == hojd)
        {
            Console.Write("X");
        }

        if (i > 1 && i< hojd)
        {
            if (j == 1 || j == bredd)
                Console.Write("X");
            else if (i > 1 && i < bredd)
            {
                Console.Write(" ");
            }

        }


    }
    Console.WriteLine("");
}
*/

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
while (counter <= 100)
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

int Hashtag = 1;
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 8; j++)
    {
        if(j != Hashtag)
        Console.Write($"-");
        else
            Console.Write($"#");
    }
    Hashtag++;
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
int height = 4;
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
