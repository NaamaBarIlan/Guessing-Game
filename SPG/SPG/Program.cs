   using System;

namespace SPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            //playOneGame();
            //displayHangman();
            //createHint();
            //readGuess();
            //getRandomWord();
            //stats();
        }

        static void Intro()
        {
            Console.WriteLine("Welcome to the Guessing game! \n" +
                              "I will think of a random word. \n" +
                              "You'll try to guess its letters.\n" +
                              "Every time you guess a letter \n" +
                              "that isn't in my word, a new body \n" +
                              "part of the person appears. \n" +
                              "Guess correctly to win!"
                              );
        }
    }
}
