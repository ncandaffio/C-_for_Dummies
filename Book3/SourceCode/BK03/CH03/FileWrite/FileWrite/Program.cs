using System;
using System.IO;

namespace FileWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = null;
            string fileName = "";

            // Get a filename from the user -- the while loop lets you
            // keep trying with different filenames until you succeed.
            while (true)
            {
                try
                {
                    // Enter output filename (simply hit Enter to quit).
                    Console.Write("Enter filename "
                                + "(Enter blank filename to quit):");
                    fileName = Console.ReadLine();

                    if (fileName.Length == 0)
                    {
                        // No filename -- this jumps beyond the while
                        // loop to safety. You’re done.
                        break;
                    }

                    // Call a method (below) to set up the StreamWriter.
                    sw = GetWriterForFile(fileName);

                    // Read one string at a time, outputting each to the
                    // FileStream open for writing.
                    WriteFileFromConsole(sw);

                    // Done writing, so close the file you just created.
                    sw.Close(); // A very important step. Closes the file too.
                    sw = null;  // Give it to the garbage collector.
                }
                catch (IOException ioErr)
                {
                    // Ooops -- Error occurred during the processing of the
                    // file -- tell the user the full name of the file:
                    // Tack the name of the default directory to the filename.

                    // Directory class
                    string dir = Directory.GetCurrentDirectory();

                    // System.IO.Path class
                    string path = Path.Combine(dir, fileName);
                    Console.WriteLine("Error on file {0}", path);

                    // Now output the error message in the exception.
                    Console.WriteLine(ioErr.Message);
                }
            }

            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }

        // GetWriterForFile -- Create a StreamWriter set up to write
        //    to the specified file.
        private static StreamWriter GetWriterForFile(string fileName)
        {
            StreamWriter sw;

            // Open file for writing in one of these modes:
            //   FileMode.CreateNew to create a file if it
            //      doesn't already exist or throw an
            //      exception if file exists.
            //   FileMode.Append to append to an existing file
            //      or create a new file if it doesn’t exist.
            //   FileMode.Create to create a new file or
            //      truncate an existing file.

            //   FileAccess possibilities are:
            //      FileAccess.Read,
            //      FileAccess.Write,
            //      FileAccess.ReadWrite.
            FileStream fs = File.Open(fileName,
                                      FileMode.CreateNew,
                                      FileAccess.Write);

            // Generate a file stream with UTF8 characters.
            // Second parameter defaults to UTF8, so can be omitted.
            sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            return sw;
        }

        // WriteFileFromConsole -- Read lines of text from the console
        //    and spit them back out to the file.
        private static void WriteFileFromConsole(StreamWriter sw)
        {
            Console.WriteLine("Enter text; enter blank line to stop");

            while (true)
            {
                // Read next line from Console; quit if line is blank.
                string input = Console.ReadLine();

                if (input.Length == 0)
                {
                    break;
                }

                // Write the line just read to output file.
                sw.WriteLine(input);

                // Loop back up to get another line and write it.
            }
        }
    }
}
