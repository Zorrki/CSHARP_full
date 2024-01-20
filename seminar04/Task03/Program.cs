// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

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
if (sizeArray > 8 || sizeArray < 0)
{
    return; // программа не работает если размер массива отрицательный или больше 8
}

int ConvertArrayToInt(int[] array)
{
    int res = 0;
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        res = res + array[i] * (int)Math.Pow(10, j); // (int) перед Math работает только с числами (не со строкой)
    }
    return res;
}

int[] array = FillArray(sizeArray, 0, 9);
// Размер массива: sizeArray, элементы: [0,100]
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Число: {ConvertArrayToInt(array)}");