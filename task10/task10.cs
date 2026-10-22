using System;
using System.Diagnostics; 

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] originalArray = new int[10000];
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = rand.Next(1, 100000);
        }

        int[] arrayForBubble = (int[])originalArray.Clone();
        int[] arrayForInsertion = (int[])originalArray.Clone();

        Stopwatch sw = new Stopwatch();
        sw.Start();
        BubbleSort(arrayForBubble);
        sw.Stop();
        Console.WriteLine($"Пузырек отработал за: {sw.ElapsedMilliseconds} мс");

        sw.Restart(); 
        InsertionSort(arrayForInsertion);
        sw.Stop();
        Console.WriteLine($"Вставки отработали за: {sw.ElapsedMilliseconds} мс");
    }

    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
}
