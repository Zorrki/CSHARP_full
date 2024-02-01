// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число:");
int numInput = Convert.ToInt32(Console.ReadLine());
if (numInput % 7 == 0 && numInput % 23 == 0)
{
    Console.WriteLine($"Число {numInput} одновременно кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {numInput} не кратно одновременно 7 и 23");
}