// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа M и N.
int FindAckerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0)
    {
        return FindAckerman(n - 1, 1);
    }
    return FindAckerman(n - 1, FindAckerman(n, m - 1));
}
Console.WriteLine(FindAckerman(3, 2));