﻿// Создать двумерный массив размеров 3х5 из целых чисел и вывести на экран
int[,] matrix = new int[3, 5];

Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 11);
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();  //для вывода массива в виде таблицы (матрицы)
}