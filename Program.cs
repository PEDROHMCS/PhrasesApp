using System;
using System.IO;

string phrasesFile = $@"{Directory.GetCurrentDirectory()}\Phrases.txt";

List<string> phrases = File.ReadLines(phrasesFile).ToList();

Random randNum = new Random();

Console.Write("Insira seu nome: ");
string name = Console.ReadLine();

Console.WriteLine("Quantas frases você precisa hoje?");
bool checkAmountOfLines = Int32.TryParse(Console.ReadLine(), out int amountOfLines);


if (!string.IsNullOrEmpty(name) && checkAmountOfLines)
{
    for (int i = 0; i < amountOfLines; i++)
    {
        int getNewNumber = randNum.Next(0, phrases.Count);
        string getPhrase = phrases[getNewNumber];
    
        Console.WriteLine($"{name}, {getPhrase}");
    }
}
