// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81
//
// Изначально 100 минимальное трехзначное число и 999 максимальное
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// && - и 
// || - или 
if (number >= 100 && number <= 999)
{
    int firstDigit = number / 100; // 256 / 100 = 2
    int thirdDigit = number % 10; // 256 % 10 = 6
    int result = firstDigit * 10 + thirdDigit * 1;
    Console.WriteLine(); // number = 256 => 26
    // Интерполяция - $"Текст {выражение} "
    Console.WriteLine($"number = {number} => {result}");
}
else // Число не трехзначное
{
    Console.WriteLine($"Число не трехзначное!");  
}