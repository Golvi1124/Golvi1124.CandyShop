string title = "Mary's Candy Shop";
string divide = "----------------------";
DateTime dateTime = DateTime.Now;
int daysSinceOpening = 1;
decimal todaysProfit = 5.5m;
bool targetAchieved = false;

string menu = @"Choose one option:
'V' to view products
'A' to add a product
'D' to delete a product
'U' to update a product";

Console.WriteLine($@"
{title}
{divide}
Today's date: {dateTime}
Days since opening: {daysSinceOpening}
Today's profit: {todaysProfit:C}$
Target achieved: {targetAchieved}
{divide}
{menu}
");
Console.ReadLine();

var usersChoice = Console.ReadLine().Trim().ToUpper();

switch (usersChoice)
{
    case "A":
        Console.WriteLine("You chose to add a product.");
        break;
    case "V":
        Console.WriteLine("You chose to view products.");
        break;
    case "D":
        Console.WriteLine("You chose to delete a product.");
        break;
    case "U":
        Console.WriteLine("You chose to update a product.");
        break;
    default:
        Console.WriteLine("Invalid choice. Please try again.");
        break;
}