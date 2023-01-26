// See https://aka.ms/new-console-template for more information

using System;
using System.Text.Json;
using PetStoreProj;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create inventory as a List of Product, the base class
        List<Product> inventory = new List<Product>();

        // Get selection from user
        Console.WriteLine("Press 1 to add Cat Food");
        Console.WriteLine("Press 2 to add a Dog Leash");
        Console.WriteLine("Press 3 to add a different product");
        Console.WriteLine("Press 4 to list inventory short format");
        Console.WriteLine("Press 5 to list inventory long format");
        Console.WriteLine("Type 'exit' to quit");
        Console.Write("Type your selection: ");
        string userInput = Console.ReadLine();

        // Begin main loop of the program
        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
                getCatFood(inventory);
            else if (userInput == "2")
                getDogLeash(inventory);
            else if (userInput == "3")
                getProduct(inventory);
            else if (userInput == "4")
            {
                Console.WriteLine();
                foreach (Product p in inventory)
                    p.shortPrint();
                Console.WriteLine();
            }
            else if (userInput == "5")
            {
                Console.WriteLine();
                foreach (Product p in inventory)
                {
                    p.longPrint();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Press 1 to add Cat Food");
            Console.WriteLine("Press 2 to add a Dog Leash");
            Console.WriteLine("Press 3 to add a different product");
            Console.WriteLine("Press 4 to list inventory short format");
            Console.WriteLine("Press 5 to list inventory long format");
            Console.WriteLine("Type 'exit' to quit");
            Console.Write("Type your selection: ");
            userInput = Console.ReadLine();
        }
    }

    // Gets info for the product and adds it to inventory
    public static void getProduct(List<Product> inventory)
    {
        Console.Write("Enter the name of the product: ");
        string name = Console.ReadLine();
        Console.Write("Enter the price of the product: ");
        decimal price;
        // make sure price is a number
        while (!decimal.TryParse(Console.ReadLine(), out price))
            Console.Write("Please enter a number: ");
        Console.Write("Enter the quantity of the product: ");
        int quantity;
        // make sure quantity is a number
        while (!int.TryParse(Console.ReadLine(), out quantity))
            Console.Write("Please enter a number: ");
        Console.Write("Enter the description of the product: ");
        string description = Console.ReadLine();
        Product p = new Product(name, price, quantity, description);
        inventory.Add(p);
    }

    // Gets info for the cat food and adds it to inventory
    public static void getCatFood(List<Product> inventory)
    {
        Console.Write("Enter the name of the cat food: ");
        string name = Console.ReadLine();
        Console.Write("Enter the price of the cat food: ");
        decimal price;
        // make sure price is a number
        while (!decimal.TryParse(Console.ReadLine(), out price))
            Console.Write("Please enter a number: ");
        Console.Write("Enter the quantity of the cat food: ");
        int quantity;
        // make sure quantity is a number
        while (!int.TryParse(Console.ReadLine(), out quantity))
            Console.Write("Please enter a number: ");
        Console.Write("Enter the description of the cat food: ");
        string description = Console.ReadLine();
        Console.Write("Enter the weight in pounds of the cat food: ");
        double weight;
        // make sure weight is a number
        while (!double.TryParse(Console.ReadLine(), out weight))
            Console.Write("Please enter a number: ");
        Console.Write("Is this kitten food (type 'true' or 'false'): ");
        bool kitten;
        // make sure kitten is a bool
        while (!bool.TryParse(Console.ReadLine(), out kitten))
            Console.Write("Please enter 'true' or 'false': ");
        CatFood cf = new CatFood(name, price, quantity, description, weight, kitten);
        inventory.Add(cf);
    }

    // Gets info for the dog leash and adds it to inventory
    public static void getDogLeash(List<Product> inventory)
    {
        Console.Write("Enter the name of the dog leash: ");
        string name = Console.ReadLine();
        Console.Write("Enter the price of the dog leash: ");
        decimal price;
        // make sure price is a number
        while (!decimal.TryParse(Console.ReadLine(), out price))
            Console.Write("Please enter a number: ");
        Console.Write("Enter the quantity of the dog leash: ");
        int quantity;
        // make sure quantity is a number
        while (!int.TryParse(Console.ReadLine(), out quantity))
            Console.Write("Please enter a number: ");
        Console.Write("Enter the description of the dog leash: ");
        string description = Console.ReadLine();
        Console.Write("Enter the length in inches of the dog leash: ");
        int length;
        // make sure length is a number
        while (!int.TryParse(Console.ReadLine(), out length))
            Console.Write("Please enter a number: ");
        Console.Write("Enter the material of the dog leash: ");
        string material = Console.ReadLine();
        DogLeash dl = new DogLeash(name, price, quantity, description, length, material);
        inventory.Add(dl);
    }


}