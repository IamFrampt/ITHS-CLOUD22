//Case sensitive    - Gör skillnad på små och stora bokstäver
//Case insensitive  - Gör inte skillnad på små och stora bokstäver

//Upppercase: MYVARIABLE
//Lowercase: myvariable
//Pascalcase: MyVariable
//Camalcase: myVariableThatIsAwesome
//Snakecase: my_variable (Python)

//------------------------------VARIABLER-------------------------------------

//Signed Integers
SByte mySByte = 8;
sbyte mySbyte = 8;          //Range: -128 till 127

Int16 myShort16 = 16;
short myShort = 16;         //Range: -32768 till 32767

Int32 myInt32 = 32;
int myInt = 32;             //Range: -2.1 miljarder till 2.1 miljarder

Int64 myInt64 = 64;
long myLong = 64;           // Range: -9.2 miljarder till 9.2 miljarder

//---------------------------------------------------------------------------

// Unsigned Integers
byte mybyte = 8;            //Range: 0 till 256
ushort myUShort = 16;       //Range: 0 till 65 536
uint myUInt = 32;           //Range: 0 till 4 294 967 296
ulong myULong = 64;         // Range: 0 till 2^64 = 18 446 744 073 709 551 616

//---------------------------------------------------------------------------

//Datatyper som lagrar siffror med decimaler
Double myDouble = 3.14;
double mydouble = 3.14;     // 32 bitar

Single mySingle = 3.14f;
float myFloat = 3.14f;      // 64 bitar

Decimal myDecimal = 3.14M;
decimal mydecimal = 3.14M;  // 128 bitar

//---------------------------------------------------------------------------

//Implict typad variabel (med keyword var)
var x = 5;
var y = "5";
var z = true;

//---------------------------------------------------------------------------

//Datatyper som lagrar tecken
String myStringDotNet = "";
string myString = "Används för att lagra text";

Char myCharDotNet = 'A';
char myChar = 'B';          // Lagrar bara ett tecken

//---------------------------------------------------------------------------

//Datatyp för att kolla om något är sant eller falskt
Boolean myBoolDotNet = true;
bool myBool = false;

//---------------------------------------------------------------------------

//Suffixer 
// f - float
// m - decimal
// l - long

//--------------------------------SCOPE--------------------------------------

string firstName = "Mikael";

//Block scope - Variabler är endast giltiga i det kodblock de deklarerats i.
if (firstName == "Mikael")
{
    string lastName = "Eriksson";
    Console.WriteLine($"{firstName} {lastName}");
}

//Function Scope: Variabler är endast giltiga i funktionen de deklareras i.
void myFunction()
{
    string text = "hejsan";
    Console.WriteLine(text);
}

myFunction(); // Funktionen körs här.




