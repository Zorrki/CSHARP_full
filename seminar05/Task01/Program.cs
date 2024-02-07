// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
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

void SquareElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  // rows = matrix.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // cols = matrix.GetLength(1)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] result = CreateMatrix(rows, cols);
int[,] resultCopy = CreateMatrix(rows, cols); // копия исходной матрицы
Console.WriteLine("Изначальная матрица: ");
PrintMatrix(result); // ДО
Console.WriteLine(" ");
Console.WriteLine("Конечный результат: ");
SquareElements(result); // Происходит умножение элементов
PrintMatrix(result); // ПОСЛЕ