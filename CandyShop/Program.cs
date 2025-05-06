string docPath = @"C:\VSTasks\CandyShop\CandyShop\history.txt";


string[] candyNames = { "Rainbow Lollipops", "Cotton Candy Clouds", "Choco-Caramel Delights", "Gummy Bear Bonanza", "Minty Chocolate Truffles",
    "Jellybean Jamboree", "Fruity Taffy Twists", "Sour Patch Surprise","Crispy Peanut Butter Cups", "Rock Candy Crystals" };
var products = new Dictionary<int, string>();
string divide = "--------------------------";

// SeedData();

if (File.Exists(docPath))
{
    LoadData();
}



var isMenuRunning = true;


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
            SaveProducts();
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

void SeedData()
{
    for (int i = 0; i < candyNames.Length; i++)
    {
        products.Add(i, candyNames[i]);
    }
}



void AddProduct()
{
    Console.WriteLine("Product name:");
    var product = Console.ReadLine();
    var index = products.Count();
    products.Add(index, product.Trim());
}
void UpdateProduct()
{
    throw new NotImplementedException();
}

void ViewProducts()
{
    foreach (KeyValuePair<int, string> product in products)
    {
        Console.WriteLine($"{product.Key}: {product.Value}");
    }
}

void DeleteProduct()
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

void SaveProducts()
{
    try
    {
        using (StreamWriter outputFile = new StreamWriter(docPath))
        {
            foreach (KeyValuePair<int, string> product in products)
            {
                outputFile.WriteLine($"{product.Key}, {product.Value}");
            }
        }
        Console.WriteLine("Products saved");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving data: {ex.Message}");
        Console.WriteLine(divide);
    }
}

void LoadData()
{
    try
    {
        using (StreamReader reader = new(docPath))
        {
            var line = reader.ReadLine();


            while (line != null)
            {
                string[] parts = line.Split(',');
                products.Add(int.Parse(parts[0]), parts[1]);
                line = reader.ReadLine();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading data: {ex.Message}");
        Console.WriteLine(divide);
    }
}