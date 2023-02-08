

int favoriteNumber = 7;

var r = new Random();
var favoriteNumber = r.Next(1, 4);

while (true)
{
    Console.WriteLine("What is my favorite number?");
    int guessedNumber = int.Parse(Console.ReadLine());

    if (guessedNumber < favoriteNumber)
    {
        Console.WriteLine("Sorry! That number is too low");
        Console.WriteLine("Try again: ");
    }
    else if (guessedNumber > favoriteNumber)
    {
        Console.WriteLine("Sorry! That number is too high");
        Console.WriteLine("Try again: ");
    }
    else
    {
        Console.WriteLine("Correct! That is my favorite number");
        break;
    }
}


Console.WriteLine("What is your favorite school subject?");
string answer = Console.ReadLine();
switch (answer.ToLower())
{
    case "math":
        Console.WriteLine("math is so cool");
        break;
    case "english":
    case "reading":
    case "writing":
        Console.WriteLine("I love reading and writing. Great choice!");
        break;
    case "lunch":
        Console.WriteLine("The best subject in the ENTIRE world.");
        break;
    default:
        Console.WriteLine($"{answer} is an interesting choice,");
        break;
