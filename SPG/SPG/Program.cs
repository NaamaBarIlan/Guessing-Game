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

            //Testing the hint:
            //CreateHint("PROGRAMMER", "R");
            //Console.ReadLine();

            //PlayOneGame("PROGRAMER");
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
            StringBuilder guessedLettersBuilder = new StringBuilder();
            string guessedLetters = guessedLettersBuilder.ToString();
            string CreateHint = "--------";


            while (guessesCounter > 0)
            {
                Console.WriteLine($"Secret word: {CreateHint}");
                Console.WriteLine($"Your guesses: {guessedLettersBuilder}");
                Console.WriteLine($"Guesses left: {guessesCounter}");
                Console.WriteLine($"Your guess? ");

                string userInput = Console.ReadLine();

                // case-insensitive - convert user input to upper case 
                string upperInput = userInput.ToUpper();

                // append user input to guessed letters string
                guessedLettersBuilder.Append(upperInput);

                guessesCounter--;
            }
            
            return guessesCounter;
        }

        /// <summary>
        /// Creates and returns a hint string
        /// </summary>
        /// <param name="secretWord">The secret word that the user is trying to guess</param>
        /// <param name="guessedLetters">The set of letters that already been guessed</param>
        /// <returns>A version of the secret word that reveals any guessed letters but shows dashes in place of all other letters</returns>
        static string CreateHint(string secretWord, string guessedLetters)
        {
            StringBuilder hintBuilder = new StringBuilder();

            foreach (char item in secretWord)
            {
                bool charMatch = false;

                for (int i = 0; i < guessedLetters.Length; i++)
                {
                    if (item.Equals(guessedLetters[i]))
                    {
                        charMatch = true;
                    }
                }

                if (charMatch)
                {
                    hintBuilder.Append(item);
                }
                else
                {
                    hintBuilder.Append("-");
                }
            }

            string hint = hintBuilder.ToString();

            // To test the hint:
            //Console.WriteLine(hint);

            return hint;
        }

        /// <summary>
        /// Prompts the user to type a single letter to guess,
        /// and returns the letter typed as an uppercase char.
        /// Re-prompts the user until they type a string that is a single letter
        /// from A-Z, case insensitive, that has not been guessed before.
        /// </summary>
        /// <param name="guessedLetters">A string representing all letters that have already been guessed</param>
        /// <returns></returns>
        static char ReadGuess(string guessedLetters)
        {

        }
    }
}
