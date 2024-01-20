// тип_метода (void или нет) ИмяМетода (параметры)
// char - 1 символ; string - массив char-ов
// str = "923" , str[0] = 9, str[1] = 2, str[3] = 3

// Простой калькулятор
int Calculate(int a, int b, char sign)
{
    int res = 0;
    if(sign == '+') // только для 1 символа
    {
        res = a + b;
    }
    else if (sign == '-')
    {
        res = a - b;
    }
    else if (sign == '*')
    {
        res = a * b;
    }
    else if (sign == '/')
    {
        res = a / b;
    }
    return res;
}

// Вызов метода: ИмяМетода(параметр1, параметр2, параметр3)
Console.WriteLine(Calculate(10, 20, '+'));
Console.WriteLine(Calculate(10, 20, '-'));
Console.WriteLine(Calculate(10, 20, '*'));
Console.WriteLine(Calculate(10, 20, '/'));
Console.WriteLine(Calculate(10, 20, '.'));