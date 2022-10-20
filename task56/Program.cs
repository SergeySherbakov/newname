int m = 4, n = 6;
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

int minsum = int.MaxValue;
int k = 0;
for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum = sum + array[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        k++;
    }
}

Console.WriteLine($"строка с наименьшей суммой №:{k}, сумма чисел: {minsum}");

