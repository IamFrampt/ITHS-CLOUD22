// Övingar under lektionen

//Variabler

using System.Text.RegularExpressions;

void ovning1()
{

    Console.WriteLine("Skriv in två tal.");
    Console.Write("Tal 1: ");
    int Tal1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Tal 2: ");
    int Tal2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Multiplikationen av {Tal1} och {Tal2} är {Tal1 * Tal2}");
}

void ovning2()
{
    Console.Write("Skriv in ditt förnamn: ");
    string firstName = Console.ReadLine();
    Console.Write("Skriv in ditt efternamn: ");
    string lastName = Console.ReadLine();
    Console.WriteLine($"Hej, {firstName} {lastName}.");
}

void ovning3()
{
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
}

void ovning4()
{

    Console.WriteLine("Skriv in ett tal.");
    Console.Write("Ditt tal: ");
    double dittTal = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{dittTal * 2} är dubbla värdet av {dittTal}");
    Console.WriteLine($"{dittTal / 2} är halva värdet av {dittTal}");
}

//Loopar

void ovning5()
{
    for (int i = 20; i <= 30; i++)
    {
        Console.Write($"{i} ");
    }
    Console.ReadKey();
    Console.Clear();
}

void ovning6()
{
    for (int i = 0; i <= 30; i++)
    {
        if (i % 2 == 0)
            Console.Write($"{i} ");
    }

    Console.ReadKey();
    Console.Clear();
}

void ovning7()
{
    for (int i = 1; i <= 30; i++)
    {
        if (i % 3 != 0)
            Console.Write($"{i} ");
        else
            Console.Write($"hej ");
    }

    Console.ReadKey();
    Console.Clear();
}

void ovning8()
{
    Console.Write("Skriv ett tal: ");
    int tal = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{tal} * {i} = {tal * i}");
    }
    Console.ReadKey();
    Console.Clear();
}

void ovning9()
{
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
}

void ovning10()
{
    Console.Write("Bredd: ");
    int bredd = Convert.ToInt32(Console.ReadLine());
    Console.Write("Höjd: ");
    int hojd = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= hojd; i++)
    {
        for (int j = 1; j <= bredd; j += 2)
        {
            Console.Write($"X");
            if (j != bredd)
                Console.Write($"O");
        }
        Console.WriteLine("");
    }
}

void ovning11()
{
    Console.Write("Bredd: ");
    int bredd = Convert.ToInt32(Console.ReadLine());
    Console.Write("Höjd: ");
    int hojd = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= hojd; i++)
    {
        for (int j = 1; j <= bredd; j += 2)
        {
            if (i % 2 == 0)
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
}

void ovning12()
{
    Console.Write("Bredd: ");
    int bredd = Convert.ToInt32(Console.ReadLine());
    Console.Write("Höjd: ");
    int hojd = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < hojd; i++)
    {
        for (int j = 0; j < bredd; j++)
        {
            if (i == 0 || i == hojd - 1)
                Console.Write("X");
            else
            {
                if (j == 0 || j == bredd - 1)
                    Console.Write("X");
                else if (j > 0 || j < bredd - 2)
                    Console.Write("-");

            }

        }
        Console.WriteLine("");
    }
}

void ovning13()
{
    for (int i = 1; i <= 9; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j);
        }
        Console.WriteLine();
    }
}

void ovning14()
{
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
}

void ovning15()
{
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
}

void ovning16()
{
    int totalSum = 0;
    for (int i = 1; i <= 1000; i++)
    {
        totalSum += i;
    }
    Console.WriteLine($"Totala summan av 1-1000 är: {totalSum}");
}

void ovning17()
{
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
}

void ovning18()
{
    ulong tempRow = 1;
    ulong tempRow2;
    ulong row = 0;
    ulong counter = 1;
    while (counter <= 100)
    {
        //for (ulong i = 0; i <= row; i++)
        //{
        //    if (i == row)
        //        Console.WriteLine(row);
        //}

        Console.WriteLine($"{counter}: {row}");
        tempRow2 = tempRow;
        tempRow = row;
        row = tempRow2 + tempRow;


        counter++;
    }
}

void ovning19()
{
    string tal = "";
    bool shutDown = false;
    double totalSum = 0;
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
            shutDown = false;
            totalSum += Convert.ToDouble(tal);
            Console.WriteLine($"Totala summan av inmatade tal är: {totalSum}");
            counter++;
        }
    }
}

void ovning20()
{
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
}

void ovning21()
{
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
}

void ovning22()
{
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
        else if (!uPåse && userGuess != "" || !uSten && userGuess != "" || !uSax && userGuess != "")
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
}

//Varianter av rektanglar i olika mönster

void VariantA()
{
    for (int i = 1; i <= 4; i++)
    {
        for (int j = 1; j <= 8; j++)
        {
            if (i == j)
                Console.Write('#');
            else
                Console.Write('-');
        }
        Console.WriteLine("");
    }
}

void VariantB()
{
    for (int i = 1; i <= 4; i++)
    {
        for (int j = 1; j <= 8; j++)
        {
            if (j == i || j == i + 4)
                Console.Write($"#");
            else
                Console.Write($"-");
        }
        Console.WriteLine("");
    }
}

void VariantC()
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (j / 2 == i)
                Console.Write($"#");
            else
                Console.Write($"-");
        }
        Console.WriteLine("");
    }
}

void VariantD()
{
    int width = 8;
    int height = 4;
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {

            if (j == 2 || j == 5 || i == 2)
                Console.Write($"#");
            else
                Console.Write($"-");

        }
        Console.WriteLine("");
    }
}

void VariantE()
{
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
}

void VariantF()
{
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
}

void VariantG()
{
    int Hashtag = 1;
    int width = 6;
    int height = 4;
    for (int i = 1; i <= 4; i++)
    {
        for (int j = 1; j <= width; j++)
        {
            if (j <= width / 2 && i != height)
                Console.Write($"#");
            else
                Console.Write($"-");

        }
        Hashtag++;
        Console.WriteLine("");
    }
}

void VariantH()
{
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
}

void VariantI()
{
    int Hashtag = 3;
    int skipRow = 2;
    int width = 5;
    int height = 16;
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
}

void VariantJ()
{
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
}

void VariantK()
{
    int Hashtag = 1;
    int fullRow = 4;
    int width = 16;
    int height = 8;
    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= width; j++)
        {
            if (i != fullRow && i != fullRow - 1)
            {
                if (j == Hashtag && j <= width / 2)
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
        Hashtag = 1;
        Console.WriteLine("");
    }
}

//Fortsättning av övningar

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
    char letter = Console.ReadKey(true).KeyChar;
    Console.WriteLine();
    int start = -1;
    int end = -1;

    for (int i = 0; i < text.Length; i++)
    {
        if (i != end)
            if (letter == text[i])
            {
                start = i;
                for (int j = start + 1; j < text.Length; j++)
                {
                    if (letter == text[j])
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

    Console.ForegroundColor = ConsoleColor.White;
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
    int wordcounter;

    while (true)
    {
        Console.WriteLine("Skriv ett ord: ");
        allWords.Add(Console.ReadLine());
        wordcounter = allWords.Count;
        if (allWords.Count >= 10)
            Console.WriteLine(allWords[wordcounter - 10]);
        else
        {
            Console.WriteLine("Du har inte skrivit 10 ord än.");
            Console.WriteLine();
        }
    }
}

void ovning36()
{
    Random moveCursorToYPos = new Random();
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

        CursorlocationY = moveCursorToYPos.Next(0, 10);
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
    }*/


    //SPELET MAIN KOD
    while (!gameover)
    {
        //Det här händer när spelet startar om
        if (reset)
        {
            Console.Clear();
            reset = false;
            direction = "Right";
            Score = 0;
            nTail = 4;
            headX = 10;
            headY = 8;
            berryX = randomnummer.Next(6, 113);
            berryY = randomnummer.Next(4, 26);

            for (int i = 0; i < nTail; i++)
            {
                TailX[i] = 0;
                TailY[i] = 0;
            }
            Drawborder();
        }

        //Om man "äter" ett bär så flyttar den postion och svansen och score plusas med 1
        if (headX == berryX && headY == berryY)
        {
            Score++;
            nTail++;
            berryX = randomnummer.Next(6, 113);
            berryY = randomnummer.Next(4, 26);
        }

        pretempX = TailX[0];
        pretempY = TailY[0];
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

        //Kollar om man nuddar någon av väggarna
        if (headX == 5 || headX == 114 || headY == 3 || headY == 26)
            gameover = true;

        //När spelet är över händer de här!
        while (gameover)
        {
            //Game over text
            direction = "";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(54, 11);
            Console.Write("YOU LOST!");
            Console.SetCursorPosition(45, 12);
            Console.Write("Press R to Restart the game.");

            keypressed = Console.ReadKey(true).Key;

            if (keypressed == ConsoleKey.R)
            {
                gameover = false;
                reset = true;
            }
        }

        Timer = DateTime.Now;
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

//ovning39();

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
    Console.WriteLine("Mata in siffror. Separera dem med ,");

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
        sizeWidth = rng.Next(3, 10);
        sizeHeight = rng.Next(3, 10);
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
    Console.WriteLine(SizeMatter(word, number));

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

    double ReturnMedelVarde(params int[] number)
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

void ovning66()
{
    Console.Write("Mata in valfritt tal: ");
    string nummer = Console.ReadLine();

    Console.Write(NumberToWords(nummer));

    string NumberToWords(string inputNumber)
    {

        string[] numberText = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio", };
        string[] numberText2 = { "elva", "tolv", "tretton", "fjorton", "femton", "sexton", "sjutton", "arton", "nitton" };
        string[] numberText3 = { "tio", "tjugo", "trettio", "fyrtio", "femtio", "sextio", "sjuttio", "åttio", "nittio" };
        string[] numberText4 = { "hundra", "tusen", "en miljon", "miljoner" };
        string newString = string.Empty;

        int inputInInt = int.Parse(inputNumber.Replace(" ", ""));
        string tempholder;

        for (int i = 0; i < inputNumber.Length; i++)
        {
            tempholder = inputInInt.ToString();

            if (inputInInt >= 1000000)
            {
                if (Convert.ToInt32(tempholder[0].ToString()) >= 2)
                {
                    newString += numberText[Convert.ToInt32(tempholder[0].ToString())] + " ";
                    newString += (numberText4[3]) + " ";
                }
                else
                    newString += (numberText4[2]) + " ";

                inputInInt = inputInInt % 1000000;
            }
            else if (inputInInt >= 100000)
            {
                newString += numberText[Convert.ToInt32(tempholder[0].ToString())] + " ";
                newString += (numberText4[0]) + " ";
                if (Convert.ToInt32(tempholder[1].ToString()) == 0)
                    newString += (numberText4[1]) + " ";
                inputInInt = inputInInt % 100000;
            }
            else if (inputInInt >= 10000)
            {
                newString += numberText3[Convert.ToInt32(tempholder[0].ToString()) - 1] + " ";
                if (Convert.ToInt32(tempholder[1].ToString()) > 0)
                    newString += (numberText[Convert.ToInt32(tempholder[0].ToString())]) + " ";

                newString += (numberText4[1]) + " ";
                inputInInt = inputInInt % 10000;
                inputInInt = inputInInt % 1000;

            }
            else if (inputInInt >= 1000)
            {
                newString += numberText[Convert.ToInt32(tempholder[0].ToString())] + " ";
                newString += (numberText4[1]) + " ";
                inputInInt = inputInInt % 1000;

            }
            else if (inputInInt >= 100)
            {
                newString += numberText[Convert.ToInt32(tempholder[0].ToString())] + " ";
                newString += numberText4[0] + " ";
                inputInInt = inputInInt % 100;
            }
            else if (inputInInt == 10 || inputInInt >= 20)
            {
                newString += (numberText3[Convert.ToInt32(tempholder[0].ToString()) - 1]) + " ";
                inputInInt = inputInInt % 10;

            }
            else if (inputInInt > 10)
            {
                newString += (numberText2[Convert.ToInt32(tempholder[1].ToString()) - 1]) + " ";
                inputInInt = inputInInt % 10;
            }
            else if (inputInInt >= 0)
            {
                if (inputNumber.Length > 1)
                {
                    break;
                }
                newString += (numberText[inputInInt]);
                break;
            }
        }

        return newString;
    }
}

void ovning67()
{
    //F = C*1.8 +32
    bool isNumber;
    double celcius = 0;

    do
    {
        celcius = 0;
        Console.Write("Skriv in grader i celcius: ");
        isNumber = double.TryParse(Console.ReadLine(), out celcius);

        if (isNumber)
            Console.WriteLine(ConvertToFarenheit(celcius));
    } while (!isNumber);

    double ConvertToFarenheit(double celciusToFarenheit)
    {
        return (celciusToFarenheit * 1.8) + 32;
    }



}

void ovning68()
{
    Console.WriteLine("Översätter din mening till rövarspråket");
    Console.Write("Din mening: ");
    string input = Console.ReadLine();
    string convertedToRovarsprak = Rovarsprak(input);
    Console.WriteLine(convertedToRovarsprak);

    string Rovarsprak(string input)
    {
        string convertedSentence = string.Empty;
        bool isRovarsprakBokstav = false;
        string[] bokstaver = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z" };

        for (int i = 0; i < input.Length; i++)
        {
            isRovarsprakBokstav = false;
            for (int j = 0; j < bokstaver.Length; j++)
            {
                if (input[i].ToString().Contains(bokstaver[j]))
                {
                    if (input[i].ToString() == bokstaver[j])
                    {
                        convertedSentence += input[i].ToString().Replace(input[i].ToString(), $"{bokstaver[j]}o{bokstaver[j]}");
                        isRovarsprakBokstav = true;
                        break;
                    }
                }
            }

            if (!isRovarsprakBokstav)
                convertedSentence += input[i].ToString();
        }
        return convertedSentence;
    }
}

void ovning69()
{
    Console.Write("Skriv ett ord: ");
    string input = Console.ReadLine();

    bool IsItAPalindrom(string input)
    {
        string reversedSentence = string.Empty;
        string[] reverseString = new string[input.Length];

        for (int i = 0; i < input.Length; i++)
            reverseString[i] = input[i].ToString();

        Array.Reverse(reverseString);
        reversedSentence = String.Join(null, reverseString);

        if (input == reversedSentence)
            return true;

        return false;
    }

    Console.WriteLine(IsItAPalindrom(input));

}

//OVNING 70

void ovning71()
{
    bool validString = false;
    int loopTimes = 1;
    do
    {
        try
        {
            Console.Write("Enter a number: ");
            loopTimes = int.Parse(Console.ReadLine());
            validString = true;
        }
        catch
        {
            Console.WriteLine("Not okey.");
        }
    } while (!validString);

    Console.WriteLine($"Fakultet är : {Fakultet(loopTimes)}");

    int Fakultet(int loopTimes)
    {
        if (loopTimes == 0)
            return 1;
        return loopTimes *= Fakultet(loopTimes - 1);
    }
}

//OVNING 72
void ovning72()
{
    bool validString = false;
    long nFibonacci = 0;
    do
    {
        try
        {
            Console.Write("Enter a number: ");
            nFibonacci = int.Parse(Console.ReadLine());
            validString = true;
        }
        catch
        {
            Console.WriteLine("Not okey.");
        }
    } while (!validString);

    Console.WriteLine($"Fibotacci är : {FibonacciR(nFibonacci)}");

    long FibonacciR(long nFibonacci, long tempRow = 1, long tempRow2 = 0, long Fibonacci = 0)
    {
        if (nFibonacci == 0)
            return Fibonacci;

        tempRow2 = tempRow;
        tempRow = Fibonacci;
        Fibonacci = tempRow2 + tempRow;
        FibonacciR(nFibonacci - 1);

        return Fibonacci;
    }
}

void ovning72v2()
{
    bool isValid = false;
    long n = 1;
    do
    {
        try
        {
            Console.Write("Fibonacci tal :# ");
            n = Int64.Parse(Console.ReadLine());
            isValid = true;
        }
        catch
        {
            Console.WriteLine("Not okey.");
        }
    } while (!isValid);

    Console.WriteLine(Fibonacci(n));

    long Fibonacci(long n)
    {
        long tempRow = 1;
        long tempRow2;
        long Fibonacci = 0;
        long counter = 0;

        while (counter < n - 1)
        {
            counter++;
            tempRow2 = tempRow;
            tempRow = Fibonacci;
            Fibonacci = tempRow2 + tempRow;
        }
        return Fibonacci;
    }
}

//OVNING 73

void ovning74()
{
    bool isValid = false;

    do
    {
        try
        {
            Console.Write("Skriv in ett tal: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine(input * 10);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + "Try again.");
        }

    } while (!isValid);

}

// KLASSER

void ovning90n91()
{
    Dog myDog = new Dog() { Name = "Hund", Breed = "Wiener Dog", Weight = 14.5 };
    Dog myFatDog = new Dog() { Name = "Katt", Breed = "Chihuahua", Weight = 3 };

    //Console.WriteLine($"Hello! My dog's name is {myDog.Name}. He's a {myDog.Breed}, His weight is {myDog.Weight}kg.");
    //Console.WriteLine($"Hello! My dog's name is {myFatDog.Name}. He's a {myFatDog.Breed}, His weight is {myFatDog.Weight}kg.");

    myDog.PrintName();
    myDog.PrintBreed();

    myFatDog.PrintName();
    myFatDog.PrintBreed();

}

void ovning92()
{
    Box box = new Box() { Height = 5, Width = 6 };

    Console.WriteLine(box.GetArea());
    Console.WriteLine(box.GetCircumference());
}

void ovning93()
{
    Box box = new Box() { Width = 10, Height = 23 };

    box.PrintArea();
    box.PrintCircumference();
}

void ovning94()
{
    User user = new User();

    user.ShowPassword();

    Console.Write("Skriv gamla lösenordet: ");
    string oldPassword = Console.ReadLine();
    Console.Write("Skriv nya lösenordet: ");
    string newPassword = Console.ReadLine();
    user.SetPassWord(newPassword, oldPassword);


    user.ShowPassword();
}

void ovning95()
{
    Car Ford = new Car() { Model = "Ford", Price = 70000, Color = "Black" };
    Car Volvo = new Car() { Model = "Volvo", Price = 250000 };
    Car Kia = new Car() { Model = "Kia" };

    Ford.WhatCar();
    Ford.HalfPrice();
    Ford.WhatCar();
}

void ovning96n97()
{
    Pedometer Jogger = new Pedometer();
    Pedometer Jogger2 = new Pedometer();
    Pedometer Jogger3 = new Pedometer();
    Pedometer Jogger4 = new Pedometer();
    Pedometer Jogger5 = new Pedometer();
    Pedometer Jogger6 = new Pedometer();
    Pedometer Jogger7 = new Pedometer();
    Pedometer Jogger8 = new Pedometer();
    Pedometer Jogger9 = new Pedometer();
    Pedometer Jogger10 = new Pedometer();
    Random rng = new Random();

    int[] AllJoggers = new int[10];

    for (int i = 0; i < 1000; i++)
    {
        int random = rng.Next(0, 10);

        switch (random)
        {
            case 0:
                AllJoggers[0] = Jogger.Step();
                break;
            case 1:
                AllJoggers[1] = Jogger2.Step();
                break;
            case 2:
                AllJoggers[2] = Jogger3.Step();
                break;
            case 3:
                AllJoggers[3] = Jogger4.Step();
                break;
            case 4:
                AllJoggers[4] = Jogger5.Step();
                break;
            case 5:
                AllJoggers[5] = Jogger6.Step();
                break;
            case 6:
                AllJoggers[6] = Jogger7.Step();
                break;
            case 7:
                AllJoggers[7] = Jogger8.Step();
                break;
            case 8:
                AllJoggers[8] = Jogger9.Step();
                break;
            case 9:
                AllJoggers[9] = Jogger10.Step();
                break;

        }
    }

    for (int i = 0; i < AllJoggers.Length; i++)
    {
        Console.WriteLine($"Jogger #{i + 1} walked: {AllJoggers[i]} steps.");
    }
}

void ovning97update36()
{
    Random moveCursorToYPos = new Random();
    Pedometer[] Counter = new Pedometer[10];

    int CursorlocationY;
    Console.CursorVisible = false;

    for (int i = 0; i < Counter.Length; i++)
    {
        Counter[i] = new Pedometer();
        Console.WriteLine(Counter[i].step);
    }

    while (true)
    {
        Thread.Sleep(1000);
        Console.SetCursorPosition(0, 0);

        CursorlocationY = moveCursorToYPos.Next(0, 10);

        switch (CursorlocationY)
        {
            case 0:
                Counter[0].Step();
                break;
            case 1:
                Counter[1].Step();
                break;
            case 2:
                Counter[2].Step();
                break;
            case 3:
                Counter[3].Step();
                break;
            case 4:
                Counter[4].Step();
                break;
            case 5:
                Counter[5].Step();
                break;
            case 6:
                Counter[6].Step();
                break;
            case 7:
                Counter[7].Step();
                break;
            case 8:
                Counter[8].Step();
                break;
            case 9:
                Counter[9].Step();
                break;

        }

        for (int i = 0; i < Counter.Length; i++)
        {
            if (Counter[i].step == 10)
            {
                Counter[i].ResetStep();
            }

            if (i == CursorlocationY)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(Counter[i].step);
        }
        Console.SetCursorPosition(0, CursorlocationY);
    }
}

void ovning98()
{
    Person Mikael = new Person("Mikael");
    Mikael.Mother = new Person("Ulla");
    Mikael.Father = new Person("Pertti");
    Mikael.Mother.Mother = new Person("Viola");
    Mikael.Mother.Father = new Person("Lars-Erik");
    Mikael.Father.Mother = new Person("Grandmother");
    Mikael.Father.Father = new Person("Grandfather");
}

void ovning99n100()
{
    Person2 Mikael = new("Mikael", "Eriksson", "The skilled");
    Person2 MikaelBMI = new(77, 1.83);
    Person2 Paulina = new("Paulina", "Jonsson");

    Console.WriteLine(Mikael.FullName);
    Console.WriteLine(Paulina.FullName);
    Console.WriteLine(MikaelBMI.BMI);
}

void ovning101()
{
    RednBlue color = new RednBlue();
    color.red = 56.4f;

    Console.WriteLine($"Red value is {color.Red}");
    Console.WriteLine($"Blue value is {color.Blue}");

}

void ovning102()
{
    Person3 mikael = new Person3("Mikael", "Eriksson");
    Person3 Paulina = new Person3("Paulina Jonsson");

    Console.WriteLine(mikael.FirstName);
    Console.WriteLine(mikael.LastName);
    Console.WriteLine(mikael.Name);
    Console.WriteLine();

    Console.WriteLine(Paulina.FirstName);
    Console.WriteLine(Paulina.LastName);
    Console.WriteLine(Paulina.Name);
}

void ovning103n104n105()
{
    Car103[] cars = new Car103[1000];
    int amount = 0;
    totalLengthOfGreenCars();

    void totalLengthOfGreenCars()
    {
        int totalLength = 0;
        for (int i = 0; i < cars.Count(); i++)
        {
            cars[i] = new Car103();

            if (cars[i].CarColor == ConsoleColor.Green)
            {
                totalLength += cars[i].CarLength;
                amount++;
            }
            //Console.ForegroundColor = cars[i].CarColor;
            //Console.WriteLine(cars[i].CarLength);
        }
        // Console.WriteLine(totalLength + " meter." + $" Green cars: {amount}.");
    }

    ////********************************104******************************************
    Car103[] DCar = new Car103[10];
    DCar = Car103.GetCars(cars[4]);
    for (int i = 0; i < DCar.Length; i++)
    {
        //Console.WriteLine(DCar[i].CarColor.ToString() + " car and " + DCar[i].CarLength + " meters.");
    }

    ////************************************105**************************************

    Car103[] tenNewCars = new Car103[10];
    for (int i = 0; i < tenNewCars.Length; i++)
    {
        tenNewCars[i] = new Car103();
        tenNewCars[i].GetGraph(tenNewCars[i].Distance);
    }

    do
    {
        Console.CursorVisible = false;
        Console.SetCursorPosition(0, 0);

        for (int i = 0; i < tenNewCars.Length; i++)
        {
            tenNewCars[i].DriveForOneHour();
            tenNewCars[i].moveCar(tenNewCars[i].Distance, tenNewCars[i].CarColor, i);
            tenNewCars[i].PrintDistance(tenNewCars[i].Distance, i);
        }
        Thread.Sleep(700);
    } while (true);

}

void ovning106()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(TemplateClass.CreateInstance()._serialNumber);
    }
    Console.WriteLine("FINISH!");

}

/// OVNING 107

void ovning108()
{
    Temperatur temp = new Temperatur(37);
    Temperatur temp2 = new Temperatur();

    Console.WriteLine(temp.Celsius);
    Console.WriteLine(temp.Farenheit);
    Console.WriteLine(temp.Kelvin);
    Console.WriteLine();
    Console.WriteLine(temp2.Celsius);
    Console.WriteLine(temp2.Farenheit);
    Console.WriteLine(temp2.Kelvin);


}

void ovning109()
{
    Number number = new Number();

    number.myNumber = 5;
    number.myNumber = 4;
    number.myNumber = 2;
    number.myNumber = 8;
    number.myNumber = 6;
    number.myNumber = 4;
    number.myNumber = 2;
    number.myNumber = 8;
    number.myNumber = 6;

    int[] historyOfAllNumbers = new int[number.GetHistory().Length];
    historyOfAllNumbers = number.GetHistory();

    foreach (int item in historyOfAllNumbers)
    {
        Console.WriteLine(item);
    }


}

void ovning110()
{
    SaveText110 Wow = SaveText110.CreateInstance("hej jag heter mikael");
    SaveText110 Wow2 = SaveText110.CreateInstance("och jag är coolast i världen");
    SaveText110 Wow3 = SaveText110.CreateInstance("köpte nyss fifa23");
    SaveText110 Wow4 = SaveText110.CreateInstance("och jag är såklart bäst");

    //SaveText110.VowelsAndConsonants();
    Console.WriteLine($"Vowels: {SaveText110._vowels}");
    Console.WriteLine($"Consonants: {SaveText110._consonants}");
    Console.WriteLine($"Total Length: {SaveText110.totalLength}");
    Console.WriteLine($"Average Length: {SaveText110.averageLength}");
}

void ovning111()
{
    WriteAndRead.Write = Console.ReadLine();
    Console.WriteLine(WriteAndRead.Read);
}

void ovning112n113n114()
{
    Func<string,string,string> printName = FullName2;
    Console.WriteLine(printName("Mikael", "Eriksson"));
    Console.WriteLine();

    FullName3(FullName2);

    string FullName(string firstName, string lastName)
    {
        return (firstName + " " + lastName);
    }
    string FullName2(string firstName, string lastName)
    {
        return $"First name: {firstName} \nLast name: {lastName}";
    }

    void FullName3(Func<string,string,string> fullname)
    {
        Console.WriteLine(fullname("Mikael","Eriksson"));
        Console.WriteLine();
        Console.WriteLine(fullname("Paulina", "Jonsson"));
        Console.WriteLine();
        Console.WriteLine(fullname("Ioannis", "Anastasiadis"));
    }
}

void ovning115()
{
    
}

ovning112n113n114();