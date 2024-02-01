// Считать с консоли строку из цифр и латинских букв
// Сформировать новую строку из букв исходной строки

string GetLettersFromString (string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);