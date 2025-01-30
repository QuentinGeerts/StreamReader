using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = "mots.txt";

        WithReadAllLines(path);
        WithStreamReader(path);
    }

    static void WithStreamReader(string path)
    {
        // StreamReader
        using (StreamReader sr = new StreamReader(path))
        {
            string? line;
            List<string> lines = new List<string>();
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);
            }
            string word = lines[Random.Shared.Next(0, lines.Count)];
            Console.WriteLine($"Mot aléatoire: {word}");
        }
    }

    static void WithReadAllLines(string path)
    {
        // File.ReadAllLines
        string[] lines = File.ReadAllLines(path);

        string word = lines[Random.Shared.Next(0, lines.Length)];

        Console.WriteLine($"Mot aléatoire: {word}");
    }
}
