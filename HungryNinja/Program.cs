using System;
using System.Collections.Generic;

namespace HungryNinja
{
    // Create a Food class - DONE
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        // Add a constructor to the Food class - DONE
        public Food(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }


    }

    // Create a Buffet class, which will contain a Menu of Food objects - DONE
    class Buffet
    {
        // add a constructor and set Menu to a hard coded list of 7 or more Food objects you instantiate manually - DONE
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {   
                new Food("Curry", 500, true, false),
                new Food("Sushi", 250, false, false),
                new Food("Gyro", 700, true, false),
                new Food("Mystery Meat", 100, false, false),
                new Food("Steak n Taters", 800, false, false),
                new Food("Ice Cream", 500, false, true),
                new Food("BBQ", 1000, true, true)
            };
        }

        // Add a constructor and Serve method to the Buffet class - DONE
        // build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object - DONE
        public Food Serve()
        {
            Random rand = new Random();       
            int x = rand.Next(0,7);
            Console.WriteLine($"Buffet is serving {Menu[x].Name}");
            return Menu[x];
        }

    }

    // Add a publc "getter" property called "IsFull" that returns a boolean based on if the Ninja's calors intake is greater than 1200 calories - DONE
    // Create a Ninja class - DONE
    class Ninja
    {
        public string Name;
        private int CalorieIntake;
        public List<Food> FoodHistory;
        private bool IsFull {get;set;}
        // Add a constructor that sets calorieIntake to 0 and creates a new list, empty list of Food objects to FoodHistory - DONE
        public Ninja(string name)
        {
            Name = name;
            CalorieIntake = 0;
            FoodHistory = new List<Food>();
            IsFull = false;
        }
        // Add a constructor, IsFull property, and an Eat method to the Ninja class - DONE
        /* 
        Build out the Eat method that: if the Ninja is NOT full - DONE
            1) Adds calorie value to ninja's total calorieIntake - DONE
            2) Adds the randomly selected Food object to ninja's FoodHistory list - DONE
            3) Writes the Food's Name - and if it is spicy/sweet to the console - DONE
        if the Ninja IS full
            1) Issues a warning to the console that the ninja is full and cannot eat anymore - DONE
        */
        public void Eat(Food item)
        {
            if(IsFull == true)
            {
                Console.WriteLine("Ninja is full and can't eat anymore!!!");
            }
            else
            {
                CalorieIntake += item.Calories;
                Console.WriteLine(CalorieIntake);
                FoodHistory.Add(item);
                Console.WriteLine(FoodHistory.Count);
                Console.WriteLine($"Ninja Eat {item.Name}");
                if(item.IsSpicy == true)
                {
                    Console.WriteLine($"{item.Name} is spicy!");
                }
                if(item.IsSweet == true)
                {
                    Console.WriteLine($"{item.Name} is sweet!");
                }
                if(CalorieIntake >= 1200)
                {
                    Console.WriteLine("Ninja is Full and can't eat anymore!!!");
                    IsFull = true;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // In your Program's Main method, instantiate a Buffet and Ninja object, and have the Ninha eat until the are full - DONE
            Console.WriteLine("All you can eat!");
            Buffet GoldenCorral = new Buffet();
            Ninja Dan = new Ninja("Dan");
            for(int i = 0; i < 5; i++)
            {
                Dan.Eat(GoldenCorral.Serve());
            }
            
        }
    }
}
