// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = -N;
// Console.WriteLine(negativeN);
if (N < 0)
{
    N *= -1; // N = N * -1
}
while (negativeN <= N)
{
    Console.Write(negativeN + "\t");  // \t - 4 пробела или табуляция
    negativeN++; // negativeN = negativeN + 1 (инкримент)
}