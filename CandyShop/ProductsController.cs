using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop;

internal class ProductsController
{
    internal List<string> GetProducts()
    {
        var products = new List<string>();

        try
        {
            using (StreamReader reader = new(Configuration.docPath))
            {
                var line = reader.ReadLine();


                while (line != null)
                {
                    string[] parts = line.Split(',');
                    products.Add(line);
                    line = reader.ReadLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading data: {ex.Message}");
            Console.WriteLine(UserInterface.divide);
        }

        return products;
    }

    internal void AddProduct()
    {
        Console.WriteLine("Product name:");
        var product = Console.ReadLine();
        try
        {
            using (StreamWriter outputFile = new StreamWriter(Configuration.docPath))
            {
                    outputFile.WriteLine(product.Trim(), true);
            }
            Console.WriteLine("Product saved");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data: {ex.Message}");
        }
    }
    internal void AddProducts(List<string> products)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(Configuration.docPath))
            {
                foreach (var product in products)
                {
                   outputFile.WriteLine(product.Trim());                    
                }

            }
            Console.WriteLine("Products saved");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data: {ex.Message}");
        }
    }

    internal void DeleteProduct(string message)
    {
        Console.WriteLine(message);
    }


    internal void UpdateProduct(string message)
    {
        Console.WriteLine(message);
    }

 


}
