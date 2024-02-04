using System;

public class Journal
{
        public List<Entry> _entries = new List<Entry>();

        public bool _loaded = false;

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);  

        }

        public void DisplayEntries()
        {
            foreach (Entry entry in _entries)
            {
                entry.DisplayEntry();
            }
        }

        public void SaveEntries()
        {
                Console.Write("Enter the desired filename to save the journal to (put .txt at the end): ");
                string filename = Console.ReadLine();

                if (File.Exists(filename) && _loaded == false)
                {
                        Console.WriteLine($"File {filename} already exists. Would you like to overwrite it without loading first? (y/n)");
                        string overwrite = Console.ReadLine();
                        if (overwrite != "y")
                        {
                                Console.WriteLine("Journal not saved.");
                                return;
                        }
                }

                using (StreamWriter writer = new StreamWriter(filename))
                {
                        foreach (Entry entry in _entries)
                        {
                                writer.WriteLine($"{entry._entryDate};;{entry._prompt};;{entry._response}");
                        }
                }

                Console.WriteLine($"Journal saved successfully to {filename}");
        }



        public void LoadEntries()
        {
                Console.Write("Enter the desired filename to load the journal from: ");
                string filename = Console.ReadLine();

                if (File.Exists(filename))
                {
                        using (StreamReader reader = new StreamReader(filename))
                        {
                                string line;
                                while ((line = reader.ReadLine()) != null) // Read the next line until no lines left
                                {
                                        string[] parts = line.Split(new string[] { ";;" }, StringSplitOptions.None);
                                
                                        Entry entry = new Entry();
                                        entry._entryDate = DateTime.Parse(parts[0]);
                                        entry._prompt = parts[1];
                                        entry._response = parts[2];
                                        _entries.Add(entry);

                                }
                        }

                        Console.WriteLine($"Journal loaded successfully from {filename}");
                        _loaded = true; // mark that the journal has been loaded and current entries can be added to file
                }
                else
                {
                        Console.WriteLine($"File {filename} does not exist.");
                }
        }


}