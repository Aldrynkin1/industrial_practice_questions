bool is_num_divide_by_two(double x)
{
    return true ? x % 2 == 0 : false;
}

Console.WriteLine(is_num_divide_by_two(5) ? "true" : "false");

bool is_num_divide_by_two_easy(double x)
{
    if (x % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine(is_num_divide_by_two_easy(4) ? "true" : "false");