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
            state = 0;
            livesRemaining = 6;
            word = wordFactory.GetWord();
            Graphics.Intro();

        }

        public void Info()
        {
            Graphics.Lives(livesRemaining);
            Graphics.DisplayLetters(word, lettersUsed.ToList());
            Console.WriteLine("\nLives Remaining:\t{0}",livesRemaining);
            Console.WriteLine("\n" + lettersUsed.ToString());
        }

        public void Guess(char guess)
        {
            //Add letter to the guessed letters
            lettersUsed.Add(Char.ToUpper(guess));

            //Reduce lives if letter is not contined in the word
            if (!word.Contains(guess))
            {
                livesRemaining -= 1;
            }

            //Check for win condition
            for (int i = 0; i < word.Length + 1; i++)
            {
                if (i == word.Length + 1) { State = 1;  }

                if (!lettersUsed.ToList().Contains(word[i]))
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
    }
}
