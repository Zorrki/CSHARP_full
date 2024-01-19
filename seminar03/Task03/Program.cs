// Найти произведение пар чисел в одномерном массиве.
// Пары - первый-последний, второй-предпоследний и т.д.
// Результат записать в новый массив

// int[] array = { 11, 22, 33, 44, 55, 66, 77 };
// Console.WriteLine($"Изначальный массив: [ {string.Join("; ", array)} ]");
// int[] result = new int[array.Length / 2]; // Размер нового массива = размер старого / 2, изначально он заполнен [0,0,0]
// for (int i = 0, j = array.Length - 1; i < result.Length; i++, j--)
// {
//     result[i] = array[i] * array[j];
// }
// Console.WriteLine($"Результат: [ {string.Join("; ", result)} ]");


//Тоже самое, только в случае если изначальный массив нечетный по количеству элементов, записать элемент без пары
//в конец нового массива
int[] array = { 2, 3, 1, 7, 5, 6, 3 };
Console.WriteLine($"Изначальный массив: [ {string.Join("; ", array)} ]");
int[] result = new int[array.Length % 2 + array.Length / 2]; // 7 % 2 + 7 / 2 = 1 + 3 = 4

for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
{
    result[i] = array[i] * array[j];
}
if (array.Length % 2 == 1)
{
    result[result.Length - 1] = array[array.Length / 2];
}
Console.WriteLine($"Результат: [ {string.Join("; ", result)} ]");