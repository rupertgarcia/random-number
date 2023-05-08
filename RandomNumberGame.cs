using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number between 1 and 100
        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        Console.WriteLine("Guess a number between 1 and 100:");
        int guess = 0;
        int numberOfGuesses = 0;

        // Loop until the player guesses the correct number
        while (guess != randomNumber)
        {
            // Get the player's guess
            string input = Console.ReadLine();
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            // Count the number of guesses
            numberOfGuesses++;

            // Check if the guess is too low, too high, or correct
            if (guess < randomNumber)
            {
                Console.WriteLine("Too low. Guess again:");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Too high. Guess again:");
            }
            else
            {
                Console.WriteLine("Congratulations, you guessed the number!");
                Console.WriteLine("Number of guesses: " + numberOfGuesses);
            }
        }

        Console.ReadLine();
    }
}
