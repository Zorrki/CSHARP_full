// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
void ShowArrayReverse(int[] arr, int size)
{
    int i = size - 1;
    if (i == 0)
    {
        Console.Write(arr[i]);
        return;
    }
    Console.Write(arr[i] + " ");
    ShowArrayReverse(arr, i);
}
int[] arr = { 1, 2, 5, 0, 8, 9, 1, 23, 10, 34 };
int size = arr.Length;
Console.WriteLine($"Изначальный массив: {string.Join(" ", arr)}");
Console.Write($"Массив наоборот: ");
ShowArrayReverse(arr, size);
