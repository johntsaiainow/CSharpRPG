using System.ComponentModel;

string hitPoints = "";
string gold = "";
string experience = "";
string level = "";

bool running = true;

while (running)
{
    DrawScreen();

    ConsoleKey key = Console.ReadKey(intercept: true).Key;

    switch (key)
    {
        case ConsoleKey.T:
            gold = "123";
            break;

        case ConsoleKey.Q:
            running = false;
            break;
    } 
}

Console.Clear();

void DrawScreen()
{
    Console.Clear();

    Console.WriteLine("+----------------------------+");
    Console.WriteLine("|      My Game               |");
    Console.WriteLine("+----------------------------+");
    Console.WriteLine($"| Hit Points: {hitPoints,-25}|");
    Console.WriteLine($"| Gold:       {gold,-25}|");
    Console.WriteLine($"| Experience: {experience,-25}|");
    Console.WriteLine($"| Level: {level,-25}|");
    Console.WriteLine("+----------------------------+");
    Console.WriteLine("|  [T] Test          [Q] Quit ");
    Console.WriteLine("+----------------------------+");
}
