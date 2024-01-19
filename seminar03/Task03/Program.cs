// Найти произведение пар чисел в одномерном массиве.
// Пары - первый-последний, второй-предпоследний и т.д.
// Результат записать в новый массив

int[] array = { 11, 22, 33, 44, 55, 66, 77 };
Console.WriteLine($"Изначальный массив: [ {string.Join("; ", array)} ]");
int[] result = new int[array.Length / 2]; // Размер нового массива = размер старого / 2, изначально он заполнен [0,0,0]
for (int i = 0, j = array.Length - 1; i < result.Length; i++, j--)
{
    result[i] = array[i] * array[j];
}
Console.WriteLine($"Результат: [ {string.Join("; ", result)} ]");
