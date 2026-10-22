using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите дату рождения (ДД.ММ.ГГГГ): ");
        string input = Console.ReadLine();

        if (!DateTime.TryParse(input, out DateTime birthDate))
        {
            Console.WriteLine("Ошибка: Некорректный формат даты.");
            return;
        }

        DateTime today = DateTime.Today;

        if (birthDate > today)
        {
            Console.WriteLine("Ошибка: Дата рождения не может быть в будущем.");
            return;
        }

        int years = today.Year - birthDate.Year;
        int months = today.Month - birthDate.Month;
        int days = today.Day - birthDate.Day;

        if (days < 0)
        {
            DateTime previousMonth = today.AddMonths(-1);
            days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            months--;
        }

        if (months < 0)
        {
            months += 12;
            years--;
        }

        Console.WriteLine($"{years} лет, {months} месяцев, {days} дней");
    }
}
