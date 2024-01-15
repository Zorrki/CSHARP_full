// Вывести на экран квадратов числе от 1 до N
void PrintSqares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}

PrintSqares(5);
PrintSqares(10);
PrintSqares(15);