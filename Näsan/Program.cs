using System.Diagnostics;

if (6 > 3)
{
    Console.WriteLine("Hello, world!");
}
// -------------------------------------------------
string namn = Console.ReadLine();
string password = Console.ReadLine();

if (namn == "kalleanka" && password == "12345")
{
    Console.WriteLine("Welcome!");
}

else
{
    Console.WriteLine("Wrong username or password");
}
// -------------------------------------------------
int x = 0;

while (x <= 32)
{
    Console.WriteLine("Hello, world!");
    x++;
}
// -------------------------------------------------
password = Console.ReadLine();

while (password != "password")
{
    Console.WriteLine("Wrong!");
    password = Console.ReadLine();
}
// -------------------------------------------------
for (int y = 0; y <= 5; y++)
{
    string tal = Console.ReadLine();

    int talsiffra = 0;

    bool success = int.TryParse(tal, out talsiffra);

    if (talsiffra >= 5)
    {
        Console.WriteLine("Högre än 5!");
    }

    else if (talsiffra <= 5)
    {
        Console.WriteLine("Mindre än 5!");
    }
}
// -------------------------------------------------
string phrase = Console.ReadLine();
int phraseNumber = 0;
bool working = false;

while (working == false)
{
    Console.WriteLine("Dedär är inte ett nummer");
    phrase = Console.ReadLine();
    working = int.TryParse(phrase, out phraseNumber);
}
// -------------------------------------------------