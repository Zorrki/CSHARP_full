// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1
// int GetVovelsCount(string str)
// {
//     string vovels = "aoueiy"; // строка с гласными буквами
//     int countVovels = 0; // количество гласных
//     foreach(char symbol in str) // 'h','e','l','l','o'
//     {
//         foreach(char vovel in vovels) // 'a','o','u','e','i','y'
//         {
//             if (symbol == vovel) // в символе строки есть гласная буква
//             {
//                 countVovels++;
//             }
//         }
//     }
//     return countVovels;
// }
// Console.Write("Введите строчку:");
// var inputString = Console.ReadLine();
// int count = GetVovelsCount(inputString);
// Console.WriteLine($"Количество гласных в {inputString} = {count}");

string str = "HeLLo";
Console.WriteLine(str.ToUpper());
Console.WriteLine(str.ToLower());
