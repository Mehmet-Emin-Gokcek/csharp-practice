using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Studio2_Counting_Characters
{
    class Program
    {
        static void Main(string[] args){

            //Ask user for text input
            Console.WriteLine("Enter your text here:");

            //Make all entries case insensitive
            String text = Console.ReadLine().ToLower();

            if (text.Length > 0) {
                Console.WriteLine("User Input Successfull!\n------------------------");
                Thread.Sleep(1000);//adding 1000ms delay to provide a better user experience
            }

            // Set a generic variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Append the user input to a file named "textData.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "textData.txt"), false)) //false clears previous content
            {
                outputFile.WriteLine(text);
                Console.WriteLine($"Text Data successfully saved to textData.txt file at {docPath}\n------------------------");
                Thread.Sleep(1000); //adding 1000ms delay to provide a better user experience
            }


            try
            {
                // Open the text file using a stream reader.
                using (var str = new StreamReader(Path.Combine(docPath, "textData.txt")))
                {
                    Console.WriteLine($"Attempting to read contents of textData.txt file at {docPath}\n------------------------");
                    Thread.Sleep(1000);

                    // Read the stream as a string, and write the string to the console.
                    String newStr = (str.ReadToEnd());

                    //Remove white space and non-alphabetic numbers
                    String trimmedText = Regex.Replace(newStr, "[^a-zA-Z]", String.Empty);

                    //Convert the string to char array
                    char[] charText = trimmedText.ToCharArray();

                    if (charText.Length > 0) {

                        Console.WriteLine("textData.txt file contents have been read successfully.\n------------------------");
                        Thread.Sleep(1000);

                        Console.WriteLine("See below for results!\n------------------------");
                        Thread.Sleep(1000);
                    }

                    //Iterate thru the char array to print the char array elements 
                    for (int i = 0; i < charText.Length; i++)
                    {
                        Console.WriteLine($"{i}: {charText[i]}");
                        Thread.Sleep(100);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
