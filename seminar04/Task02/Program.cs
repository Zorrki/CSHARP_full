// задать массив из N случайных целых чисел (вводится с клавиатуры)
// Найти количество чисел, которые оканчиваются на 1 и делятся нацело на 7
// [1 5 11 21 81 4 0 91 2 3]

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
int[] array = FillArray(sizeArray, 0, 100);
// Размер массива: sizeArray, элементы: [0,100]
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");

int GetCountOfInterestingElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 7 == 0 && array[i] % 10 == 1)
        // Число делится нацело на 7 и оканчивается на 1
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Количество чисел: {GetCountOfInterestingElements(array)}");