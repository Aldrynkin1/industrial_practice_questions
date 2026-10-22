using System;

class Program
{
    static void Main()
    {
        Console.Write("Первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Оператор (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        switch (op)
        {
            case "+":
                Console.WriteLine($"Результат: {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Результат: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Результат: {num1 * num2}");
                break;
            case "/":
                if (num2 == 0) Console.WriteLine("Ошибка: Деление на ноль!");
                else Console.WriteLine($"Результат: {num1 / num2}");
                break;
            default:
                Console.WriteLine("Неизвестная операция");
                break;
        }
    }
}
