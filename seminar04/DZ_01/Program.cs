// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


while (true)
{
    Console.Write("Ввод: ");
    string text = Console.ReadLine();
    if (text == "q")
    {
        break;
    }

    int number = Convert.ToInt32(text);
    int sum = 0;
    while (number > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    if (sum % 2 == 0)
    {
        break;
    }
}