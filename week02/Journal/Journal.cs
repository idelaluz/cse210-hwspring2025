public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        // Add the new entry to the list of entries
    }

    public void DisplayAll()
    {
        // Display all entries in the journal entry list
        
    }

    public void SaveToFile(string file)
    {
        // Loop through each item in _entries and save them in a file
    }

    public void LoadFromFile(string file)
    {
        // Loop through each line of the file and create Entry objects to put in the _entries list
    }
}