using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // asking for input for breakfast food
            Console.WriteLine("What did you eat for breakfast?");
            string breakfastFood = Console.ReadLine();

            // asking for input for breakfast drink
            Console.WriteLine("What did you drink for breakfast?");
            string breakfastDrink = Console.ReadLine();

            // asking for input for lunch food
            Console.WriteLine("What did you eat for lunch?");
            string lunchFood = Console.ReadLine();

            // asking for input for lunch drink
            Console.WriteLine("What did you drink for lunch?");
            string lunchDrink = Console.ReadLine();

            // asking for input for supper food
            Console.WriteLine("What did you eat for supper?");
            string supperFood = Console.ReadLine();

            // asking for input for supper drink
            Console.WriteLine("What did you drink for supper?");
            string supperDrink = Console.ReadLine();

            Console.WriteLine($"I ate {breakfastFood} and drank {breakfastDrink} for breakfast.");
            Console.WriteLine($"I ate {lunchFood} and drank {lunchDrink} for lunch.");
            Console.WriteLine($"I ate {supperFood} and drank {supperDrink} for supper.");


        }
    }
}
