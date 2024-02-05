// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
int[,] CreateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    Random rnd = new Random();
    // матрица, размер - rows строк и cols столбцов
    for (int i = 0; i < rows; i++)  // rows = matrix.GetLength(0)
    {
        for (int j = 0; j < cols; j++) // cols = matrix.GetLength(1)
        {
            matrix[i, j] = rnd.Next(11);  // [0;10]
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  // rows = matrix.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // cols = matrix.GetLength(1)
        {
            Console.Write($"{matrix[i, j]}\t"); // \t = 4 пробела
        }
        Console.WriteLine();
    }
}

int GetSumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)  // rows = matrix.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // cols = matrix.GetLength(1)
        {
            if (i == j) // номер строки = номеру столбца
            {
                sum += matrix[i, j];
            }
        }
    }
    return sum;
}


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] result = CreateMatrix(rows, cols);
int[,] resultCopy = CreateMatrix(rows, cols); // копия исходной матрицы
Console.WriteLine("Изначальная матрица: ");
PrintMatrix(result); // ДО
Console.WriteLine($"Результат: {GetSumMainDiagonal(result)}");