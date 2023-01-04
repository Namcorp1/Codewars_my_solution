

string BreakCamelCase(string str)
{
    string output = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsUpper(str[i]))
        {
            output += " ";
        }
        output += str[i];
    }
    //добавил на случай ввода 1ого заглавного символа, 
    //чтобы избежать пробела в начале, 
    //на Сodewars и без этого решение было принято
    if (char.IsUpper(str[0])) output = output.Remove(0,1);
    return output;
}

string text = BreakCamelCase("ForExampleTask");
Console.WriteLine(text);