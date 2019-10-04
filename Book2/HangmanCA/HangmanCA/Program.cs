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
                Console.WriteLine("Guess a letter: ");
                charConsole.Read();

            }
            

            


            

            Console.Read();
        }
    }
}
