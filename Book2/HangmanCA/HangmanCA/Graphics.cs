using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanCA
{
    class Graphics
    {
        public static void Intro()
        {
            Console.WriteLine("\n" +
                "  o         o                                                                               \n" +
                " <|>       <|>                                                                              \n" +
                " < >       < >                                                                              \n" +
                "  |         |      o__ __o/  \\o__ __o     o__ __o/  \\o__ __o__ __o      o__ __o/  \\o__ __o  \n" +
                "  o__/_ _\\__o     /v     |    |     |>   /v     |    |     |     |>    /v     |    |     |> \n" +
                "  |         |    />     / \\  / \\   / \\  />     / \\  / \\   / \\   / \\   />     / \\  / \\   / \\ \n" +
                " <o>       <o>   \\      \\o/  \\o/   \\o/  \\      \\o/  \\o/   \\o/   \\o/   \\      \\o/  \\o/   \\o/ \n" +
                "  |         |     o      |    |     |    o      |    |     |     |     o      |    |     |  \n" +
                " / \\       / \\    <\\__  / \\  / \\   / \\   <\\__  < >  / \\   / \\   / \\    <\\__  / \\  / \\   / \\ \n" +
                "                                                |                                           \n" +
                "                                        o__     o                                           \n" +
                "                                        <\\__ __/>                   press enter...          \n");
            Console.Read();
            Console.Clear();
        }

        public static void Lives(int lives)
        {
            switch (lives)
            {
                case 6:
                    Console.WriteLine(
                        "                                                                                  \n" +
                        "                           __________________                                     \n" +
                        "                          |   ______________|                                     \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "              ____________|__|_________________________________________           \n" +
                        "*~~~~~~~~~~~~|                                                        |~~~~~~~~~~*\n" +
                        "                                                                                  \n");
                    break;

                case 5:
                    Console.WriteLine(
                        "                                                                                  \n" +
                        "                           __________________                                     \n" +
                        "                          |   ______________|                                     \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |            O                                       \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "              ____________|__|_________________________________________           \n" +
                        "*~~~~~~~~~~~~|                                                        |~~~~~~~~~~*\n" +
                        "                                                                                  \n");
                    break;

                case 4:
                    Console.WriteLine(
                        "                                                                                  \n" +
                        "                           __________________                                     \n" +
                        "                          |   ______________|                                     \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |            O                                       \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "              ____________|__|_________________________________________           \n" +
                        "*~~~~~~~~~~~~|                                                        |~~~~~~~~~~*\n" +
                        "                                                                                  \n");
                    break;

                case 3:
                    Console.WriteLine(
                        "                                                                                  \n" +
                        "                           __________________                                     \n" +
                        "                          |   ______________|                                     \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |            O                                       \n" +
                        "                          |  |            |/                                      \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "              ____________|__|_________________________________________           \n" +
                        "*~~~~~~~~~~~~|                                                        |~~~~~~~~~~*\n" +
                        "                                                                                  \n");
                    break;

                case 2:
                    Console.WriteLine(
                        "                                                                                  \n" +
                        "                           __________________                                     \n" +
                        "                          |   ______________|                                     \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |            O                                       \n" +
                        "                          |  |           \\|/                                      \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "              ____________|__|_________________________________________           \n" +
                        "*~~~~~~~~~~~~|                                                        |~~~~~~~~~~*\n" +
                        "                                                                                  \n");
                    break;

                case 1:
                    Console.WriteLine(
                        "                                                                                  \n" +
                        "                           __________________                                     \n" +
                        "                          |   ______________|                                     \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |            O                                       \n" +
                        "                          |  |           \\|/                                      \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |             \\                                      \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "              ____________|__|_________________________________________           \n" +
                        "*~~~~~~~~~~~~|                                                        |~~~~~~~~~~*\n" +
                        "                                                                                  \n");
                    break;

                case 0:
                    Console.WriteLine(
                        "                                                                                  \n" +
                        "                           __________________                                     \n" +
                        "                          |   ______________|                                     \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |            O                                       \n" +
                        "                          |  |           \\|/                                      \n" +
                        "                          |  |            |                                       \n" +
                        "                          |  |           / \\                                      \n" +
                        "                          |  |                                                    \n" +
                        "                          |  |                                                    \n" +
                        "              ____________|__|_________________________________________           \n" +
                        "*~~~~~~~~~~~~|                                                        |~~~~~~~~~~*\n" +
                        "                                                                                  \n");
                    break;

                default:
                    break;
            }
        }

        public static void DisplayLetters(string word, List<char> guessedLetters)
        {
            StringBuilder letters = new StringBuilder();

            if (guessedLetters == null)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    letters.Append("_ ");
                }
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (guessedLetters.Contains(word[i]))
                    {
                        letters.Append(word[i] + " ");
                    }
                    else
                    {
                        letters.Append("_ ");
                    }
                }
            }

            Console.WriteLine(letters.ToString());
        }
    }
}

    