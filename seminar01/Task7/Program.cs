using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input) && input.Length >= 3 && int.TryParse(input, out _))
        {
            char thirdDigit = input[2];
            Console.WriteLine($"Третья цифра введенного числа: {thirdDigit}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод числа. Пожалуйста, введите целое число длиной не менее 3 символов.");
        }
    }
}