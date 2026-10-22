void FizzNuzz(int num)
{
    if (num > 100 || num < 1) return;

    for (int i = 0; i < num; i++)
    {
        if (i % 15 == 0)
        {
            Console.WriteLine("FizzBuzz");
            continue;
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
            continue;
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
            continue;
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}

FizzNuzz(100);