using System;
namespace PetStoreProj
{
    public class DogLeash : Product
    {
        // Properties

        public int LengthInches { get; set; }

        public string Material { get; set; }

        // Constructor

        public DogLeash(string name, decimal price, int quantity, string description, int length, string material) : base(name, price, quantity, description)
        {
            this.LengthInches = length;
            this.Material = material;
        }

        // Methods
        public override void longPrint()
        {
            Console.WriteLine($"Name: {this.Name}\nPrice: ${this.Price}\nQuantity: {this.Quantity}\nDescription: {this.Description}\nLength: {this.LengthInches}\nMaterial: {this.Material}");
        }
    }
}

