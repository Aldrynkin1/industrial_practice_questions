using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        char[] separators = { ' ', '.', ',', '!', '?', '-', ';', ':', '(', ')', '"', '\n', '\r' };
        string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        foreach (string w in words)
        {
            string lowerWord = w.ToLower();
            if (wordCounts.ContainsKey(lowerWord))
            {
                wordCounts[lowerWord]++;
            }
            else
            {
                wordCounts[lowerWord] = 1;
            }
        }

        List<KeyValuePair<string, int>> sortedList = new List<KeyValuePair<string, int>>(wordCounts);
        
        sortedList.Sort((x, y) => y.Value.CompareTo(x.Value));

        Console.WriteLine("\nРезультат подсчета:");
        foreach (var pair in sortedList)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
