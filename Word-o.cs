using System;
using System.Collections.Generic;

class WordO
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of words (separated by commas):");
        string input = Console.ReadLine();

        List<string> words = new List<string>(input.Split(','));

        List<string> wordsWithO = new List<string>();

        foreach (string word in words)
        {
            if (word.Contains("o"))
            {
                wordsWithO.Add(word);
            }
        }

        Console.WriteLine("Words containing 'o':");
        foreach (string word in wordsWithO)
        {
            Console.WriteLine(word);
        }
    }
}

