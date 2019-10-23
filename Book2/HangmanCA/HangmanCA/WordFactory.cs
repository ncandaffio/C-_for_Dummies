using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanCA
{
    class WordFactory
    {
        List<string> library = new List<string>
        {
            "Awkward",
            "Bagpipes",
            "Banjo",
            "Bungler",
            "Croquet",
            "Dwarves",
            "Crypt",
            "Fervid",
            "Fishhook",
            "Fjord",
            "Gazebo",
            "Gypsy",
            "Haiku",
            "Haphazard",
            "Hyphen",
            "Ivory",
            "Jazzy",
            "Jiffy",
            "Jinx",
            "Jukebox",
            "Kayak",
            "Kiosk",
            "Klutz",
            "Memento",
            "Mystify",
            "Numbskull",
            "Ostracize",
            "Oxygen",
            "Pajama",
            "Phlegm",
            "Pixel",
            "Polka",
            "Quad",
            "Quip",
            "Rhythmic",
            "Rogue",
            "Sphinx",
            "Squawk",
            "Swivel",
            "Toady",
            "Twelfth",
            "Unzip",
            "Waxy",
            "Wildebeest",
            "Yacht",
            "Zealous",
            "Zigzag",
            "Zippy",
            "Zombie"
        };

        public string GetWord()
        {
            Random rand = new Random();
            return library[rand.Next(library.Count)].ToUpper();
        }
            

    }
}
