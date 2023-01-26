using System;
namespace PetStoreProj
{
    public class CatFood : Product
    {
        // Properties

        public double WeightPounds { get; set; }

        public bool KittenFood { get; set; }

        // Constructor

        public CatFood(string name, decimal price, int quantity, string description, double weight, bool kitten) : base(name, price, quantity, description)
        {
            this.WeightPounds = weight;
            this.KittenFood = kitten;
        }

        // Methods

        public override void longPrint()
        {
            Console.WriteLine($"Name: {this.Name}\nPrice: ${this.Price}\nQuantity: {this.Quantity}\nDescription: {this.Description}\nWeight: {this.WeightPounds}\nKitten: {this.KittenFood}");
        }
    }
}

