namespace CandyShop;

internal class DataSeed
{

    string[] candyNames = { "Rainbow Lollipops", "Cotton Candy Clouds", "Choco-Caramel Delights", "Gummy Bear Bonanza", "Minty Chocolate Truffles",
    "Jellybean Jamboree", "Fruity Taffy Twists", "Sour Patch Surprise","Crispy Peanut Butter Cups", "Rock Candy Crystals" };

    void SeedData()
    {
        for (int i = 0; i < candyNames.Length; i++)
        {
            products.Add(i, candyNames[i]);
        }
    }


}
