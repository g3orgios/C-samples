using System;

Console.WriteLine("Enter a list of words separated by commas:");
string input = Console.ReadLine();
string[] words = input.Split(',');
foreach (string word in words)
{
    if (IsPalindrome(word))
    {
        Console.WriteLine(word);
    }
}

bool IsPalindrome(string word)
{
    for (int i = 0; i < word.Length / 2; i++)
    {
        if (word[i] != word[word.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}
