using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop;

internal static class UserInterface
{
    internal const string divide = "--------------------------";
    internal static void RunMainMenu()
    {
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

    }

    internal static void ViewProducts()
    {
        foreach (KeyValuePair<int, string> product in products)
        {
            Console.WriteLine($"{product.Key}: {product.Value}");
        }
    }

    internal static void PrintHeader()
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

    internal static string GetMenu()
    {
        return
        @"Choose one option:
'V' to view products
'A' to add a product
'D' to delete a product
'U' to update a product
'Q' to quit the program";
    }

}
