using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanCA
{
    class Game
    {
        public int State { get; private set; }
        private string word;
        private int livesRemaining;
        private GuessedLetters lettersUsed = new GuessedLetters();
        private WordFactory wordFactory = new WordFactory();

        public Game()
        {
            State = 0;
            livesRemaining = 6;
            word = wordFactory.GetWord();
            Graphics.Intro();

        }

        public void Info()
        {
            Graphics.Lives(livesRemaining);
            Graphics.DisplayLetters(word, lettersUsed.ToList());
            Console.WriteLine("\nLives Remaining: " + livesRemaining);
            Console.WriteLine("\n" + lettersUsed.ToString());
        }

        public void Guess(char guess)
        {
            //Add letter to the guessed letters
            if (!lettersUsed.Contains(Char.ToUpper(guess)))
            {
                lettersUsed.Add(Char.ToUpper(guess));
            }
            
            //Reduce lives if letter is not contined in the word
            if (!word.Contains(Char.ToUpper(guess)))
            {
                livesRemaining -= 1;
            }

            //Check for win condition
            for (int i = 0; i < word.Length + 1; i++)
            {
                if (i == word.Length) { State = 1;  break; }

                if (!lettersUsed.ToList().Contains(Char.ToUpper(word[i])))
                {
                    break;
                }
            }

            //Check for lose condition
            if (State == 0)
            {
                if (livesRemaining == 0)
                {
                    State = 2;
                }
            }
        }

        public void Win()
        {
            this.Info();
            Console.WriteLine("\n\nYOU WIN!");
        }

        public void Lose()
        {
            this.Info();
            Console.WriteLine("\n\nYOU LOSE!");
            Console.WriteLine("\nThe correct answer was {0}", word);
        }
    }
}
