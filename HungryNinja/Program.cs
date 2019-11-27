using System;

namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spocr and or sweet
        public bool IsSpicy;
        public bool IsSweet;
        // DONE:add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
    class Buffet
    {
        public List<Food> Menu;

        // constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Curry", 500, true, false)
                new Food("Sushi", 250, false, false)
                new Food("Gyro", 700, true, false)
                new Food("Mystery Meat", 100, false, false)
                new Food("Steak n Taters", 800, false, false)
                new Food("Ice Cream", 500, false, true)
                new Food("BBQ", 1000, true, true)
                
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            
        }
    }

    class HungryNinja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        // add a constructor

        // add a public "getter" property called "ItsFull"

        // build out the Eat method
        public void Eat(Food item)
        {

        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    }
}
