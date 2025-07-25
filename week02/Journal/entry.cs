using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        Prompt = prompt;
        Response = response;
    }

    public void Display()
    {
        Console.WriteLine($"\nDate: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }

    public string FormatForFile()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static Entry ParseFromFile(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            Entry entry = new Entry(parts[1], parts[2]);
            entry.Date = parts[0];
            return entry;
        }
        return null;
    }
}
