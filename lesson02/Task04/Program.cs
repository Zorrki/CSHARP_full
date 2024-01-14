using static System.Array;
int n = 6;
int[] array = { 11, 2, 4, 7, 3, 9 };
int i = 0;
int max = array[0];
while(i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);