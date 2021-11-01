using System;
namespace BudgetHouse
{
    public class MenuItem
    {
        public static Random Randomizer = new Random();

        public string[] Protines = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };

        public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };

        public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };

        public string Description = "";

        public string Price;

        public void Generate()
        {
            string randomProtine = Protines[Randomizer.Next(Protines.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];

            Description = $"{randomProtine} with {randomCondiments} on {randomBread}";

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * 0.01M);
            Price = price.ToString("c");
        }
        
    }
}
