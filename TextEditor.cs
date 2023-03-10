using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Text Editor!");
            Console.WriteLine("-----------------------");
            
            while (true)
            {
                Console.WriteLine("1. Create a new file");
                Console.WriteLine("2. Open an existing file");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter file name: ");
                    string fileName = Console.ReadLine();

                    Console.WriteLine("Start typing. Press CTRL+S to save and exit.");

                    string input = Console.ReadLine();
                    while (input != "CTRL+S")
                    {
                        input += Environment.NewLine + Console.ReadLine();
                    }

                    File.WriteAllText(fileName, input);
                    Console.WriteLine("File saved.");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter file name: ");
                    string fileName = Console.ReadLine();

                    if (File.Exists(fileName))
                    {
                        string content = File.ReadAllText(fileName);
                        Console.WriteLine(content);
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting Text Editor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}
