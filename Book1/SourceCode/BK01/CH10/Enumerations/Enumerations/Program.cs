﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        // Create an enumeration.
        enum Colors {Red, Orange, Yellow, Green, Blue, Purple};
        enum Colors2
        {
            Red = 5,
            Orange = 10,
            Yellow = Orange + 5,
            Green = 5 * 4,
            Blue = 0x19,
            Purple = Orange | Green
        }

        enum Colors3: byte {Red, Orange, Yellow, Green, Blue, Purple};

        [Flags]
        enum Colors4
        {
            Red = 0x01,
            Orange = 0x02,
            Yellow = 0x04,
            Green = 0x08,
            Blue = 0x10,
            Purple = 0x20
        }

        static void Main(string[] args)
        {
            // Display the color name.
            Console.WriteLine(Colors.Blue);

            // Display the color value.
            Console.WriteLine((int)Colors.Blue);

            // Display all the elements starting with names.
            foreach (String Item in Enum.GetNames(typeof(Colors)))
                Console.WriteLine(Item);

            // Display the values too.
            foreach (Colors Item in Enum.GetValues(typeof(Colors)))
                Console.WriteLine("{0} = {1}", Item, (int)Item);

            // Display a range of names.
            for (Colors Item = Colors.Orange; Item <= Colors.Blue; Item++)
                Console.WriteLine("{0} = {1}", Item, (int)Item);

            // Display Colors2.
            foreach (Colors2 Item in Enum.GetValues(typeof(Colors2)))
                Console.WriteLine("{0} = {1}", Item, (int)Item);

            // Display Colors3.
            foreach (Colors3 Item in Enum.GetValues(typeof(Colors3)))
                Console.WriteLine("{0} is {1} = {2}", 
                    Item, Item.GetTypeCode(), (int)Item);

            // Create a variable containing three color options.
            Colors4 myColors = Colors4.Red | Colors4.Green | Colors4.Purple;

            // Display the result.
            Console.WriteLine(myColors);
            Console.WriteLine("0x{0:X2}", (int)myColors);

            // Create an ambiguous switch statement.
            int mySelection = 2;
            switch (mySelection)
            {
                case 0:
                    Console.WriteLine("You chose red.");
                    break;
                case 1:
                    Console.WriteLine("You chose orange.");
                    break;
                case 2:
                    Console.WriteLine("You chose yellow.");
                    break;
                case 3:
                    Console.WriteLine("You chose green.");
                    break;
                case 4:
                    Console.WriteLine("You chose blue.");
                    break;
                case 5:
                    Console.WriteLine("You chose purple.");
                    break;
            }

            // Create a readable switch statement.
            Colors myColorSelection = Colors.Yellow;
            switch (myColorSelection)
            {
                case Colors.Red:
                    Console.WriteLine("You chose red.");
                    break;
                case Colors.Orange:
                    Console.WriteLine("You chose orange.");
                    break;
                case Colors.Yellow:
                    Console.WriteLine("You chose yellow.");
                    break;
                case Colors.Green:
                    Console.WriteLine("You chose green.");
                    break;
                case Colors.Blue:
                    Console.WriteLine("You chose blue.");
                    break;
                case Colors.Purple:
                    Console.WriteLine("You chose purple.");
                    break;
            }

            // Wait for user to acknowledge.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
