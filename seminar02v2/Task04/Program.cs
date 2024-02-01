// Напишите программу, которая выводит третью цифру c конца (третья цифра справа)
// от заданного числа или сообщает что ее нет
// 456 => 4
// 7812 => 8
// 91 => нет третьей цифры

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;
if (number < 100)
{
    Console.WriteLine("Число не трехзначное!");
}
else // в числе больше 3 цифр
{
    int digitCount = 0; // количество цифр справа
    int digit = 0; // Третья цифра справа
    while (digitCount < 3) // цикл по отбрасыванию цифр
    {
        digit = number % 10;
        number /= 10;
        digitCount++;
    }
        Console.WriteLine($"Третья цифра с конца {copyNumber} = {digit}");
}
