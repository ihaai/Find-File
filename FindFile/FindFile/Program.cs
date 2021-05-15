using System;
using System.IO;

namespace FindFile
{
    class Program
    {
        public static void findIt(string dest, string extension)
        {
            string path = $"{dest}";
            string[] fileNames = Directory.GetFiles(path, $"*.{extension}");

            if (fileNames.Length != 0)
            {
                try
                {
                    foreach (string fileName in fileNames)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"\tFOUND FILE: '{fileName}' with EXTENSION '{extension}'\n");
                    }
                }
                catch
                {
                    Console.Write("Error");
                }
            }
            else
            {
                Console.WriteLine("No files found");
            }
            Console.WriteLine($"Total files found: {fileNames.Length}");
            Console.ReadLine();
        }

        static void Main()
        {
            string one, two;
            Console.Write("Destination: ");
            one = Console.ReadLine();
            Console.Write("Extension (no . needed): ");
            two = Console.ReadLine();
            findIt(one, two);
        }
    }
}
