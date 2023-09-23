using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry anEntry in _entries)
        {
            anEntry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry anEntry in _entries)
            {
                writer.WriteLine($"{anEntry._date},{anEntry._promptText},{anEntry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[2];

            Console.WriteLine($"Date: {_date} - Prompt: {_promptText}.");
            Console.WriteLine($"> {_entryText}.");
        }
    }
}