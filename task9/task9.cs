using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] arr = new int[20];

        Console.Write("Массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 101);
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine("\n");

        int min = arr[0];
        int max = arr[0];
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
            sum += arr[i];
        }

        double avg = (double)sum / arr.Length;

        Console.WriteLine($"Минимум: {min}");
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Среднее: {avg}");
    }
}
