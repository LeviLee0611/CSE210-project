using System;

class Program
{
    static void Main(string[] args)
    {
        var word = new Word("computer");
        Console.WriteLine(word.GetText());

        word.Hide();
        Console.WriteLine(word.GetText());
    }
}

