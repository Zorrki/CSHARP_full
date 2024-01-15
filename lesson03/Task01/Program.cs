// Вычислить значение (axb)/(c+d) где a,b,c,d целые числа
double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    double denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);