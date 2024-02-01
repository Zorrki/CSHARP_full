// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
// Console.Write("Введите любое натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 1)
// {
//     // Создаем строку для хранения цифр числа через запятую.
//     string result = "";
//     int copyNumber = number;
//     while (copyNumber > 0)
//     {
//         // Получаем последнюю цифру числа.
//         int lastDigit = copyNumber % 10;
//         // Добавляем цифру в начало строки с результатом.
//         result = $"{lastDigit}, {result}";
//         // Убираем последнюю цифру числа.
//         copyNumber /= 10;
//     }
//     // Убираем последнюю запятую и выводим результат.
//     Console.WriteLine(result.TrimEnd(',', ' '));
// }
// else
// {
//     // Если введено число меньше 1, выводим сообщение об ошибке.
//     Console.WriteLine("Это не натуральное число!");
// }


Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
//Взяли число number -> в строчку ("123")
string stringNumber = number.ToString();
//Точка старта, условие выхода;
for (int i = 0; i < stringNumber.Length; i++)
{
    Console.Write(stringNumber[i]);

    if (i < stringNumber.Length - 1)   //stringNumber.Length,ищем последний элемент массива
    {
        Console.Write(", ");
    }
}