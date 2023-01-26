using System;
namespace PetStoreProj
{
    public class Product
    {
        // Properties

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        // Constructor

        public Product(string name, decimal price, int quantity, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Description = description;
        }

        // Methods

        public void shortPrint()
        {
            Console.WriteLine($"Name: {this.Name} Price: ${this.Price} Quantity: {this.Quantity}");
        }

        public virtual void longPrint()
        {
            Console.WriteLine($"Name: {this.Name}\nPrice: ${this.Price}\nQuantity: {this.Quantity}\nDescription: {this.Description}");
        }
    }
}

