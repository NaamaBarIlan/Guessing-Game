using System;
using System.Text;

namespace SPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Console.ReadLine();
            Console.Clear();

            PlayOneGame("PROGRAMER");
            //displayHangman();
            //readGuess();
            //getRandomWord();
            //stats();
        }

        /// <summary>
        /// Prints the program introduction to the player.
        /// </summary>
        static void Intro()
        {
            Console.WriteLine("Welcome to the Guessing game! \n\n" +
                              "I will think of a random word. \n" +
                              "You'll try to guess its letters.\n" +
                              "Every time you guess a letter \n" +
                              "that isn't in my word, a new body \n" +
                              "part of the person appears. \n" +
                              "Guess correctly to win!"
                              );
        }

        /// <summary>
        /// Plays a single game with the user from start to finish.
        /// </summary>
        /// <param name="secretWord">The secret word for the user to guess</param>
        /// <returns>The number of guesses the player had remaining at the end of the game, 
        /// or 0 if the player lost the game</returns>
        static int PlayOneGame(string secretWord)
        {
            int guessesCounter = 8;
            StringBuilder guessedLetters = new StringBuilder();
            string CreateHint = "--------";


            while (guessesCounter > 0)
            {
                Console.WriteLine($"Secret word: {CreateHint}");
                Console.WriteLine($"Your guesses: {guessedLetters}");
                Console.WriteLine($"Guesses left: {guessesCounter}");
                Console.WriteLine($"Your guess? ");

                string userInput = Console.ReadLine();

                // case-insensitive - convert user input to upper case 
                string upperInput = userInput.ToUpper();

                // append user input to guessed letters string
                guessedLetters.Append(upperInput);

                guessesCounter--;
            }
            

            return guessesCounter;

        }

        static string CreateHint(string secretWord, string guessedLetters)
        {

        }
    }
}
