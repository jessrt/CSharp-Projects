//Jessica Thomas 

using System;

namespace FindTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplaySettings();
            bool finished = false;
            Random rSecret = new Random();
            int secret = rSecret.Next(1, 1001);
            int count = 0;
            string message = "";

            while (!finished)
            {
                count++;
                Console.WriteLine("Guess the secret number. It's between 1 and 1000!");
                string sGuess = Console.ReadLine();

                if (!int.TryParse(sGuess, out int guess))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                if (guess == secret)
                {
                    message = $"That's correct! You found the number in just {count} tries!";
                    finished = true; 
                }
                else if (guess > secret) message = "Too big. Try again.";
                else if (guess < secret) message = "Too small. Try again.";

                Console.WriteLine(message);
            } 
        }

        static void DisplaySettings()
        {
            Console.Title = "Guess the Number!";
            Console.SetWindowSize(Console.LargestWindowWidth/2, Console.LargestWindowHeight/2);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White; 
        }
    }
}
