// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int size, int minRange, int maxRange)
{
    int[] arr = new int[size]; // Массив на size элементов
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minRange, maxRange + 1);
        // Next (0,2) => 0,1 (правая граница исключена)
    }
    return arr;
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
if (sizeArray < 0)
{
    return; // программа не работает если размер массива отрицательный
}

int HowMuchEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = FillArray(sizeArray, 100, 1000);
// Размер массива: sizeArray, элементы: [0,100]
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Четных чисел в массиве: {HowMuchEvenNumbers(array)}");