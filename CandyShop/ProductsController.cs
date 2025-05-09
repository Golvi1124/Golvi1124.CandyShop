using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop;

internal class ProductsController
{
    void AddProduct()
    {
        Console.WriteLine("Product name:");
        var product = Console.ReadLine();
        var index = products.Count();
        products.Add(index, product.Trim());
    }

    void DeleteProduct(string message)
    {
        Console.WriteLine(message);
    }


    void UpdateProduct(string message)
    {
        Console.WriteLine(message);
    }

    void SaveProducts()
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(Configuration.docPath))
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
            using (StreamReader reader = new(Configuration.docPath))
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

}
