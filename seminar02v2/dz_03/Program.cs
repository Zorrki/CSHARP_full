// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
Console.Write("Введите число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10 && number <= 99)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;    
    // Console.Write($"числа {firstDigit} и {secondDigit}");
    if (firstDigit > secondDigit)
    {
        Console.Write($"Наибольшая цифра числа первая {firstDigit}");
    }
    else if (firstDigit == secondDigit)
    {
         Console.Write($"Обе цифры в числе одинаковые");       
    }
    else
    {
        Console.Write($"Наибольшая цифра числа вторая {secondDigit}");
    }
}
else
{
    Console.Write("Ошибка! Нужно ввести число от 10 до 99!!!");
}