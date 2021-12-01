using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            DisplayGreeting();

            Directions();

            GuessNumber(1, 1024);

            goto Start;
        }

        static void DisplayGreeting()
        {
            Console.WriteLine("#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣");
            Console.WriteLine("Welcome to Number Guesser");
            Console.WriteLine("#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣#️⃣");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Directions()
        {
            Console.WriteLine("🎩 I am The Magical Number Guesser🎩 ");
            Console.WriteLine();
            Console.WriteLine("Think of a number between 1 and 1024 and I will guess it. ");
            Console.WriteLine();
            Console.WriteLine("Hit ENTER if you are ready to play ");
            Console.ReadLine();

        }

        static void GuessNumber(int low, int high)
        {
            var median = (low + high) / 2;
            Console.WriteLine($"Is your number {median}? Type 'y' for yes, 'l' for lower, or 'h' for higher. ");
            var userInput = Console.ReadLine();

            if (userInput == "y")
            {
                Console.WriteLine("");
                Console.WriteLine("Told you so! ");
                Console.WriteLine("");
            }

            else if (userInput == "l")
            {
                var newMax = median;
                GuessNumber(low, newMax);
            }

            else if (userInput == "h")
            {
                var newMin = median;
                GuessNumber(newMin, high);
            }



        }
    }
}
