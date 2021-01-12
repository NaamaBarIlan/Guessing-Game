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
            //createHint();
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
            StringBuilder builder = new StringBuilder();
            string guessedLetters = builder.ToString();
            string hint = "--------";


            while (guessesCounter > 0)
            {
                Console.WriteLine($"Secret word: {hint}");
                Console.WriteLine($"Your guesses: {guessedLetters}");
                Console.WriteLine($"Guesses left: {guessesCounter}");
                Console.WriteLine(guessedLetters);
                Console.WriteLine($"Your guess? ");

                string userInput = Console.ReadLine();

                // convert user input from string into upper case char
                //char upperInput = Convert.ToChar(userInput.ToUpper());

                string upperInput = userInput.ToUpper();

                // append user input to guessed letters string
                builder.Append(upperInput);

                guessesCounter--;
            }
            

            return guessesCounter;

        }
    }
}
