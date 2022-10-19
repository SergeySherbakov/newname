/*int m = 3, n = 4;

double[,] array = CreateArray(m, n);

double[,] CreateArray(int _m, int _n)
{
    double[,] _array = new double[_m, _n];
    for (int i = 0; i < _m; i++)
    {
        for (int j = 0; j < _n; j++)
        {
            _array[i, j] = (double)new Random().Next(-10, 10 * 10) / 10;
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
    return _array;
}*/

int m = 3, n = 4;

double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = (double)new Random().Next(-10, 10 * 10) / 10;
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
