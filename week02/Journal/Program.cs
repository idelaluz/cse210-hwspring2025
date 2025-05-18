using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        Console.WriteLine("Welcome to the Personal Journal Program!");
        String choice;

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Load entries from file");
            Console.WriteLine("4. Save entries to file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Enter your journal entry: ");
                string entryText = Console.ReadLine();

                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToString("dd.MM.yyyy"),
                    _promptText = prompt,
                    _entryText = entryText
                };

                journal.AddEntry(entry);

            }
            
            else if (choice == "2")
            {
            }
            else if (choice == "3")
            {
            }
            else if (choice == "4")
            {
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
            Console.WriteLine();
        }
        while (choice != "5");
    }

}    
