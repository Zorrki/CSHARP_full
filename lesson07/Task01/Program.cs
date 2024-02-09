// Рекурсия - вызов метода внутри метода
// string SayHello()
// {
//     SayHello();
//     return "Привет, мир!";
// }
// Console.WriteLine(SayHello());



// Факториал - произведениеп чисел от 1 до N включительно -> n! = n * (n - 1) * (n - 2) *... * 
// int FindFactorial(int n)
// {
//     //Базовый случай - выход из рекурсии
//     if (n == 1) return 1;
//     //Рекурсивный случай
//     return n * FindFactorial(n - 1);
// }
// Console.WriteLine(FindFactorial(3));


// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9
int FindSumOfDigits(int number)
{
    //Базовый случай
    if (number == 0) return 0;
    //Рекурсивный случай
    int result = number % 10 + FindSumOfDigits(number / 10);
    return result;
}
Console.WriteLine(FindSumOfDigits(22123));