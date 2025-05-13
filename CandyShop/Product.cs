namespace CandyShop;

internal class Product
{
    private string name;

    internal string Name
    {
        get
        {
            return name.ToUpper();
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Invalid name. Must be a non-empty string");
            }
        }
    }

    /*
    internal string GetName()
    {
        return name;
    }

    internal void SetName(string value)
    {
        name = value;
    }
    */

}
