int m = 4, n = 6;
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(20);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

int a, b;
int.TryParse(Console.ReadLine()!, out a);
b = a % 10;
a /= 10;

if (a >= array.GetLength(0) || b >= array.GetLength(1) || a < 0)
    Console.Write($"Такого числа в массиве нет!");
else
{
    Console.Write($"{array[a, b]}");
}
