using System;

namespace HangmanCA
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (game.State == 0)
            {
                game.Info();
                bool correctGuess = false;
                string guessString;

                while (!correctGuess)
                {
                    Console.WriteLine("Guess a letter");
                    guessString = Console.ReadLine();

                    try
                    {
                        char guess = Char.Parse(guessString);

                        if (Char.IsLetter(guess))
                        {
                            game.Guess(guess);
                            correctGuess = true;
                            Console.Clear();
                        }
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Invalid input: Please enter a single letter");

                    }
                }

                switch (game.State)
                {
                    case 1:
                        game.Win();
                        break;
                    case 2:
                        game.Lose();
                        break;
                    default:
                        break;
                }

            }
            

            


            

            Console.Read();
        }
    }
}
