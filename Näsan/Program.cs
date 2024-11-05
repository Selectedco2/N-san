if (6 > 3)
{
    Console.WriteLine("Hello, world!");
}
// -------------------------------------------------
string namn = Console.ReadLine();
string password = Console.ReadLine();

if (namn == "noname" && password == "nopass")
{
    Console.WriteLine("Welcome!");
}

else
{
    Console.WriteLine("Wrong username or password");
}
// -------------------------------------------------
int x = 0;

while (x  <= 32)
{
    x++;
    Console.WriteLine("Hello, world!");
}
// -------------------------------------------------
password = Console.ReadLine();

while (password != "password")
{
    Console.WriteLine("Wrong!");
    password = Console.ReadLine();
}
// -------------------------------------------------