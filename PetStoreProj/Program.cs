// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using PetStoreProj;

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");
string userInput = Console.ReadLine();
while(userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
        CatFood cf = new CatFood();
        string input;
        Console.Write("Enter the name of the cat food: ");
        string name = Console.ReadLine();
        Console.Write("Enter the price of the cat food: ");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the quantity of the cat food: ");
        int quantity = int.Parse(Console.ReadLine());
        Console.Write("Enter the description of the cat food: ");
        string description = Console.ReadLine();
        Console.Write("Enter the weight in pounds of the cat food: ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Is this kitten food (type 'true' or 'false'): ");
        bool kitten = bool.Parse(Console.ReadLine());
        cf.Name = name;
        cf.Price = price;
        cf.Quantity = quantity;
        cf.Description = description;
        cf.WeightPounds = weight;
        cf.KittenFood = kitten;
        Console.WriteLine(JsonSerializer.Serialize(cf));
    }
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}