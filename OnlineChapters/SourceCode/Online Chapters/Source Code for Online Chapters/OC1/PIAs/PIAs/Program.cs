using System;
using Microsoft.Office.Interop.Excel;

namespace PIAs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a reference to Excel and start the application.
            Microsoft.Office.Interop.Excel.Application xl = 
                new Application();

            // Make it possible to see the application.
            xl.Visible = true;

            // Wait to see the window.
            Console.WriteLine("Press Any Key When Ready...");
            Console.Read();

            // Close Excel.
            xl.Quit();
        }
    }
}
