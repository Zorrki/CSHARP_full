// Напишите программу, которая выводит третью цифру (начиная отсчет слева, т.е. с начала)
// от заданного числа
// 1234567 -> 3
// 7890 -> 9
// 123 -> 3
// 91 -> третьей цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;
if (number >= 100)  // Число минимум трехзначное
{
    while (number >= 1000) // делим пока число имеет больше 3х знаков
    {
        number /= 10; // number = number / 10
    }
    int thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра от числа {copyNumber} = {thirdDigit}");
}
else
{
    Console.WriteLine("Число не трехзначное!");
}