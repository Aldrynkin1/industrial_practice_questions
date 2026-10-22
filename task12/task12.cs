using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string cleanStr = "";
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleanStr += char.ToLower(c);
            }
        }

        bool isPalindrome = true;
        int left = 0;
        int right = cleanStr.Length - 1;

        while (left < right)
        {
            if (cleanStr[left] != cleanStr[right])
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }

        Console.WriteLine(isPalindrome ? "true" : "false");
    }
}
