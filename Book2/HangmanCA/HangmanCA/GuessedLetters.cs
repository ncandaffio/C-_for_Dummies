using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanCA
{
    class GuessedLetters
    {
        List<char> _letters = new List<char>();

        public void Add(char letter)
        {
            _letters.Add(letter);
        }

        public List<char> ToList()
        {
            return _letters;
        }

        public override string ToString()
        {
            StringBuilder listOfLetters = new StringBuilder();

            for (int i = 0; i < _letters.Count; i++)
            {
                listOfLetters.Append(_letters[i]);

                if (i != _letters.Count)
                {
                    listOfLetters.Append(", ");
                }
            }

            return "Letters Used: " + listOfLetters.ToString();

        }

        public bool Contains(char letter)
        {
            return _letters.Contains(letter);
        }
    }
}
