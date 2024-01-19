// Задать массив из 10 элементов, заполненный числами из промежутка [-10, 10]
// Заменить отрицательные элементы на положительные и наоборот

int[] array = { -1, -2, -3, -4, -5, 6, 7, 8, 9, 10 };
Console.WriteLine($"Изначальный массив: [{string.Join("; ", array)} ]");
for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1; // array[i] * -1
    //Console.Write(array[i] + "\t");
}
Console.WriteLine($"=====================");
Console.WriteLine($"Итоговый массив: [{string.Join("; ", array)} ]");
