// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5
void ShowNumbers(int start, int end)
{
    //Базовый случай
    if (start == end)
    {
        Console.Write(start);
        return;
    }
    Console.Write(start + " ");
    ShowNumbers(start + 1, end);
}
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers(1, N);
