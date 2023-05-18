using System;
class fILEmANAGER {
    public void SaveJournal(Journal journal, string filename){

        using (StreamWriter outputFile = new StreamWriter(filename)) {

            foreach (var entry in journal._entries) {

             string data = $"{entry._date};{entry._prompt};{entry._text}";  
             outputFile.WriteLine(data); 
            }
        }
    }

    public Journal LoadJournal (string filename) {

        string[] lines = System.IO.File.ReadAllLines(filename);
        Journal journal = new Journal ();

        foreach (string line in lines) {

            string[] parts = line.Split(";");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._prompt = prompt;
            entry._text = text;

            journal._entry.Add(entry);
        }

        return journal;
    }
}