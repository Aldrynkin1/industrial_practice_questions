using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы N (не меньше 2): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine("Ошибка: размер должен быть не меньше 2.");
            return;
        }

        int[,] matrix = new int[n, n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rand.Next(1, 10);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += matrix[i, i];
        }

        Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
    }
}
