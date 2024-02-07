// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
char[] ConvertStringToCharArray(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
        // chars[0] = str[0] = 'H';
        // 'H','','','','',''
    }
    return chars;
}
string testString = "Hello world";
char[] chars = ConvertStringToCharArray(testString);
Console.WriteLine($"[{string.Join("; ", chars)}]");