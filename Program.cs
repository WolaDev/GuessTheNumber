// • A Number Guessing Game by WolaDev\\
Console.Title = "Guess The Possible Number";

// • You have 5 lives when you start the game. One life is deducted once you guess a number.
// If inputed number is greater than 100, you did not follow the rules.
//  If the number guessed correctly two times consecutively, you get a life.

// Remove the starting and ending newline (\n) before publishing the app.
Console.WriteLine("\n========== Welcome to WolaDev Number Guessing Game. ==========\n\n ~ Rules of the game:\n\t* You have 5 lives as you start this game.\n\t* You can only guess between 1 - 10.\n\t* 1 life is deducted as you guess a wrong number\n\t* You get an extra life if you guess a numbers correctly.\n===============\n");

try
{

Console.Write("Enter 'Start' or 'S' to start the game: ");
string startGame = Console.ReadLine()!;

// if the input is not correct, it will ask for input again.
while (!(startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("+---------------------------+\n| Wrong Input, Try again!!! |\n+---------------------------+");
    Console.ResetColor();
    Console.Write("Enter 'Start' or 'S' to start the game: ");
    startGame = Console.ReadLine()!;

}

// • 5 lives default
int lives = 5;
if (startGame.Equals("Start", StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase))
{
    // lives = 5;
    Console.WriteLine("\n==========\nYou started the game!!!\n==========");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"=========================\n You have {lives} live(s) left.\n=========================\n");
    Console.ResetColor();
}

Console.Write("What will the number be? ");
int UserGuessedNum = int.Parse(Console.ReadLine()!);
Random random = new();
// • Guess the number between 0 - 10
int ComputerGuessedNum = random.Next(1, 11);

if (UserGuessedNum == ComputerGuessedNum)
{
    lives++;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Congratulations!!! You guess the number correctly.\nThe Number: {ComputerGuessedNum}\nYour guess: {UserGuessedNum}");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"=========================\n You have {lives} live(s) left.\n=========================\n");
    Console.ResetColor();
}
else
{
    lives--;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Sorry!!! You did not guess the number correctly.\nThe Number: {ComputerGuessedNum}\nYour guess: {UserGuessedNum}");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"=========================\n You have {lives} live(s) left.\n=========================\n");
    Console.ResetColor();
}

// Continue the game

Console.Write("Did you want to continue, Yes (y) or No (n)? ");
string ContinueGame = Console.ReadLine()!;

while (ContinueGame.Equals("Yes", StringComparison.OrdinalIgnoreCase) || ContinueGame.Equals("Y", StringComparison.OrdinalIgnoreCase))
{
    Console.Write("What will the number be? ");
    UserGuessedNum = int.Parse(Console.ReadLine()!);
    ComputerGuessedNum = random.Next(1, 11);

    if (UserGuessedNum == ComputerGuessedNum)
    {
        lives++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Congratulations!!! You guess the number correctly.\nThe Number: {ComputerGuessedNum}\nYour guess: {UserGuessedNum}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"=========================\n You have {lives} live(s) left.\n=========================\n");
        Console.ResetColor();
    }
    else
    {
        lives--;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Sorry!!! You did not guess the number correctly.\nThe Number: {ComputerGuessedNum}\nYour guess: {UserGuessedNum}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"=========================\n You have {lives} live(s) left.\n=========================\n");
        Console.ResetColor();
    }

    if (lives <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("+--------------------------------------------------------+\n| Sorry!!! You have zero (0) life left, come back later. |\n+--------------------------------------------------------+");
        Console.ResetColor();
        return;
    }
}

while (ContinueGame.Equals("No", StringComparison.OrdinalIgnoreCase) || ContinueGame.Equals("N", StringComparison.OrdinalIgnoreCase))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("====================\nThank you for playing Guessing Game by WolaDev.\n\nWe would love to have you back later!!!\n====================");
    Console.ResetColor();
    return;
}

while (!(ContinueGame.Equals("No", StringComparison.OrdinalIgnoreCase) || ContinueGame.Equals("N", StringComparison.OrdinalIgnoreCase)) && !(ContinueGame.Equals("Yes", StringComparison.OrdinalIgnoreCase) || ContinueGame.Equals("Y", StringComparison.OrdinalIgnoreCase)))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("====================\nSorry, you enter a wrong input. Please Try Again!!!\nEnter Yes (y) or No (N) to start the game: ");
    Console.ResetColor();
    ContinueGame = Console.ReadLine()!;
}
while (ContinueGame.Equals("Yes", StringComparison.OrdinalIgnoreCase) || ContinueGame.Equals("Y", StringComparison.OrdinalIgnoreCase))
{
    Console.Write("What will the number be? ");
    UserGuessedNum = int.Parse(Console.ReadLine()!);
    ComputerGuessedNum = random.Next(1, 11);

    if (UserGuessedNum == ComputerGuessedNum)
    {
        lives++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Congratulations!!! You guess the number correctly.\nThe Number: {ComputerGuessedNum}\nYour guess: {UserGuessedNum}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"=========================\n You have {lives} live(s) left.\n=========================\n");
        Console.ResetColor();
    }
    else
    {
        lives--;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Sorry!!! You did not guess the number correctly.\nThe Number: {ComputerGuessedNum}\nYour guess: {UserGuessedNum}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"=========================\n You have {lives} live(s) left.\n=========================\n");
        Console.ResetColor();
    }

    if (lives <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("+--------------------------------------------------------+\n| Sorry!!! You have zero (0) life left, come back later. |\n+--------------------------------------------------------+");
        Console.ResetColor();
        return;
    }
}
}

catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("+----------------------------------------------------+\n| Wrong format inputed!!! Try again later, thank you.|\n+----------------------------------------------------+");
    Console.ResetColor();
}