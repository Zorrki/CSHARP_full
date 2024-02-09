// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”
string GetStringFromCharArray(char[] array)
{
    string result = string.Empty; // ""  
    //var автоматически определит тип данных
    foreach (char symbol in array)
    {
        result += symbol; // result = result + symbol;
    }
    return result;
}
char[] chars = {'1','a','|','2','f'};
string str = GetStringFromCharArray(chars);
Console.WriteLine($"Результат: {str}");
