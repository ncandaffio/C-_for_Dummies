using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        public struct ColorList
        {
            private string[] names;

            public string this[int i]
            { get => names[i]; set => names[i] = value; }

            public void Add(string ColorName)
            {
                if (names == null)
                {
                    names = new string[1];
                    names[0] = ColorName;
                }
                else
                {
                    names = names.Concat<string>(
                        new string[] { ColorName }).ToArray();
                }
            }

            public int Length
            { get => names.Length; }

            public static ColorList operator + (ColorList First, ColorList Second)
            {
                ColorList Output = new ColorList();

                for (int i = 0; i < First.Length; i++)
                    Output.Add(First[i]);

                for (int i = 0; i < Second.Length; i++)
                    Output.Add(Second[i]);

                return Output;
            }
        }

        public struct Message
        {
            private int msgID;
            public int ProductID;
            public int Qty;
            public double Price;
            public const int genericProduct = 22;

            public int MsgID { get => msgID; set => msgID = value; }

            public Message(
                int msgId, int productId = genericProduct, int qty = 5)
            {
                // Provided by the user.
                msgID = msgId;
                ProductID = productId;
                Qty = qty;

                // Defined by the application.
                if (ProductID == 22)
                {
                    Price = CalculatePrice(5.99, qty);
                }
                else
                {
                    Price = CalculatePrice(6.99, qty);
                }
            }

            public static double CalculatePrice(
                double SinglePrice, int Qty)
            {
                return SinglePrice * Qty;
            }

            public override string ToString()
            {
                // Create a useful output string.
                return "Message ID:\t" + MsgID +
                    "\r\nProduct ID:\t" + ProductID +
                    "\r\nQuantity:\t" + Qty +
                    "\r\nTotal Price:\t" + Price;
            }
        }

        static void Main(string[] args)
        {
            // Create the struct.
            Message myMsg = new Message();

            // Create a message.
            myMsg.MsgID = 1;
            myMsg.ProductID = Message.genericProduct;
            myMsg.Qty = 5;

            // Compute the price.
            myMsg.Price = Message.CalculatePrice(5.99, myMsg.Qty);

            // Display the struct on screen.
            DisplayMessage(myMsg);

            // Create the struct using a constructor.
            Message myMsg2 = new Message(2);

            // Display the struct on screen.
            DisplayMessage(myMsg2);

            // Display all the messages on screen.
            Message[] Msgs = { myMsg, myMsg2 };
            DisplayMessages(Msgs);

            // Create a color list.
            ColorList myList = new ColorList();

            // Fill it with values.
            myList.Add("Yellow");
            myList.Add("Blue");

            // Display each of the elements in turn.
            for (int i = 0; i < myList.Length; i++)
                Console.WriteLine("Color = " + myList[i]);

            // Create and fill a second color list.
            ColorList myList2 = new ColorList();
            myList2.Add("Red");
            myList2.Add("Purple");

            // Add the first list to the second.
            ColorList myList3 = myList + myList2;

            // Display each of the elements in turn.
            for (int i = 0; i < myList3.Length; i++)
                Console.WriteLine("myList3 Color = " + myList3[i]);

            // Use the ToString() method.
            Console.WriteLine(myMsg.ToString());

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }

        static void DisplayMessage(Message msg)
        {
            Console.WriteLine(
               "In response to Msg {0}, you can get {1} of {2} for {3}.",
               msg.MsgID, msg.Qty, msg.ProductID, msg.Price);
        }

        static void DisplayMessages(Message[] msgs)
        {
            foreach (Message item in msgs)
            {
                Console.WriteLine(
                   "In response to Msg {0}, you can get {1} of {2} for {3}.",
                   item.MsgID, item.Qty, item.ProductID, item.Price);
            }
        }
    }
}
