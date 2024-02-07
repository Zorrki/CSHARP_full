// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
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
    for (int i = 0; i < matrix.GetLength(0); i++)  // rows = matrix.GetLength(0) - строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // cols = matrix.GetLength(1) - столбцы
        {
            Console.Write($"{matrix[i, j]}\t"); // \t = 4 пробела
        }
        Console.WriteLine();
    }
}

double[] GetArrayWithMeans(int[,] matrix)
{
    double[] means = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)  // rows = matrix.GetLength(0) - строки
    {
        double currentSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) // cols = matrix.GetLength(1) - столбцы
        {
            currentSum += matrix[i, j];
        }
        double currentMean = Math.Round(currentSum / matrix.GetLength(1), 2);  // Math.Round округление (выражение, до_скольки_знаков_округлять)
        means[i] = currentMean;
    }
    return means;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] result = CreateMatrix(rows, cols);
int[,] resultCopy = CreateMatrix(rows, cols); // копия исходной матрицы
Console.WriteLine("Изначальная матрица: ");
PrintMatrix(result); // ДО
Console.WriteLine($"Результат: [{string.Join("; ",GetArrayWithMeans(result))}]");