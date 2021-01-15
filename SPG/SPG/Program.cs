using System;
using System.Linq;
using System.Text;

namespace SPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            //Console.ReadLine();
            //Console.Clear();

            PlayOneGame("PRO");

            //Testing CreateHint:
            //CreateHint("PROGRAMMER", "R");
            //Console.ReadLine();

            //Testing ReadGuess:
            //ReadGuess("TO");


            //displayHangman();
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

            while (guessesCounter > 0)
            {
                Console.WriteLine($"Secret word: {CreateHint(secretWord, guessedLettersBuilder.ToString())}");
                Console.WriteLine($"Your guesses: {guessedLettersBuilder}");
                Console.WriteLine($"Guesses left: {guessesCounter}");
                
                char userGuess = ReadGuess(guessedLettersBuilder.ToString());

                guessedLettersBuilder.Append(userGuess);

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
            bool inputReadable = false;
            char guess = '\0';

            while (!inputReadable)
            {
                Console.WriteLine("Your guess? ");

                char userInput = char.Parse(Console.ReadLine().ToUpper());

                if (!Char.IsLetter(userInput))
                {
                    Console.WriteLine("Type a single letter from A-Z.");
                }
                else if(AlreadyGuessed(guessedLetters, userInput))
                {
                    Console.WriteLine("You already guessed that letter.");
                }
                else
                {
                    inputReadable = true;
                    guess = userInput;
                }
            }
            return guess;
        }

        /// <summary>
        /// Compares the letter that the user guessed to
        /// the string of letters that were guessed in previous turns.
        /// </summary>
        /// <param name="guessedLetters">A string of all the letter the user guessed in the current game</param>
        /// <param name="guess">The letter the user guessed in the current turn</param>
        /// <returns>True if the letter exists in the string and therefor already guessed</returns>
        static bool AlreadyGuessed(string guessedLetters, char guess)
        {
            for (int i = 0; i < guessedLetters.Length; i++)
            {
                if (guess.Equals(guessedLetters[i]))
                {
                    return true;
                }
            }

            return false;
        }

        static void GuessFeedback(string secretWord, char guess)
        {
            bool correctGuess = false;

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (guess.Equals(secretWord[i]))
                {
                    correctGuess = true;
                }
            }

            if (correctGuess)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }

        }
    }
}
