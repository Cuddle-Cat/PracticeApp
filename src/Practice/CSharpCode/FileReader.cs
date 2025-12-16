using System;
using System.IO;

class FileReader
{
    public static void Run()
    {
        string path = "log.txt";

        if (!File.Exists(path))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(path);

        int lineCount = lines.Length;
        int charCount = 0;
        int errorLines = 0;

        foreach (string line in lines)
        {
            charCount += line.Length;

            if (line.IndexOf("ERROR", StringComparison.OrdinalIgnoreCase) >= 0)
                errorLines++;
        }

        Console.WriteLine($"Total Lines: {lineCount}");
        Console.WriteLine($"Total Characters: {charCount}");
        Console.WriteLine($"Lines Containing 'ERROR': {errorLines}");
    }
}
