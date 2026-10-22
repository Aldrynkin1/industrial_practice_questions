int sum_of_nums(int num)
{
    if (num < 0) num = -num; 

    int sum = 0;
    while (num > 0) { 
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

Console.WriteLine(sum_of_nums(123)); 


int sum_of_nums_string(int num)
{
    if (num < 0) num = -num;

    string s = num.ToString();
    int sum = 0;
    
    foreach (char c in s) {
        sum += int.Parse(c.ToString());
    }

    return sum;
}

Console.WriteLine(sum_of_nums_string(123)); 
