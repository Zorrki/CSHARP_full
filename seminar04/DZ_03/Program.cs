// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
if (sizeArray < 0)
{
    return; // программа не работает если размер массива отрицательный 
}

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

int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

int[] array = FillArray(sizeArray, 0, 10);
// Размер массива: sizeArray, элементы: [0,100]
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Массив наоборот: [ {string.Join("; ", ReverseArray(array))} ]");