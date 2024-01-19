// Задать массив и написать программу которая определяет, присутствует ли заданное число в массиве
// Ответ да/нет
// Например [1 3 4 19 3] , 8 => нет ИЛИ 3 => да

// тип_данных[] имя_массива = ...
int[] array = { 11, 22, 33, 44, 55, 66, 77 };
Console.Write("Введите число для поиска: ");
int numberForSearch = Convert.ToInt32(Console.ReadLine());
//bool isFound = false; //Число в массиве еще не найдено
string isFound = "не найден";

for (int i = 0; i < array.Length; i++)
{
    if (numberForSearch == array [i]) // если число например 33 то сравниваем каждое число в массиве и проверяем
    {
        //isFound = true; // число найдено
        isFound = "найден";
        break; // ломает цикл как только найден элемент массива
    }
}
    Console.Write($"Элемент {numberForSearch}: {isFound}");

// if (isFound == true)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }