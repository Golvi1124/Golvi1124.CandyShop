var isMenuRunning = true;
var products = new List<string>();

while (isMenuRunning)
{
    PrintHeader();

    var usersChoice = Console.ReadLine().Trim().ToUpper();
    var menuMessage = "Press any key to go back to menu!";

    switch (usersChoice)
    {
        case "A":
            AddProduct();
            break;
        case "D":
            DeleteProduct();
            break;
        case "V":
            ViewProducts();
            break;
        case "U":
            UpdateProduct();
            break;
        case "Q":
            menuMessage = "Goodbye!";
            isMenuRunning = false;
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
    Console.WriteLine(menuMessage);
    Console.ReadLine();
    Console.Clear();
}






void UpdateProduct()
{
    throw new NotImplementedException();
}

void ViewProducts()
{
    throw new NotImplementedException();
}

void DeleteProduct()
{
    throw new NotImplementedException();
}

void AddProduct()
{
    throw new NotImplementedException();
}

string GetMenu()
{
    return
    @"Choose one option:
'V' to view products
'A' to add a product
'D' to delete a product
'U' to update a product
'Q' to quit the program";
}

int GetDaysSinceOpening()
{
    var openingDate = new DateTime(2023, 1, 1);
    TimeSpan timeDifference = DateTime.Now - openingDate;

    return timeDifference.Days;
}

void PrintHeader()
{
    string title = "Mary's Candy Shop";
    string divide = "--------------------------";
    DateTime dateTime = DateTime.Now;
    // var daysSinceOpening = GetDaysSinceOpening();
    decimal todaysProfit = 5.5m;
    bool targetAchieved = false;
    var menu = GetMenu();



    Console.WriteLine($@"
{title}
{divide}
Today's date: {dateTime}
Days since opening: {GetDaysSinceOpening()}
Today's profit: {todaysProfit}$
Target achieved: {targetAchieved}
{divide}
{menu}
");
}