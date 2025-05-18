using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        // Add the new entry to the list of entries
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // Display all entries in the journal entry list
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }

    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line, Split ('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry()
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                _entries.Add(entry);
            }
        }
    }
}
