string string_education(string str)
{
    if (str == "")
    {
        return "";
    }

    string new_str = "";
    for (int i = str.Length - 1; i >= 0; i--)
    {
        new_str += str[i];
    }

    return new_str;
}

Console.WriteLine(string_education("abc"));
Console.WriteLine(string_education("a"));
Console.WriteLine(string_education(""));