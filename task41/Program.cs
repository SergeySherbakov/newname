int n;
Console.WriteLine($"Введите количество чисел: ");
int.TryParse(Console.ReadLine()!, out n);

int[] array = new int[n];
Console.WriteLine($"Введите числа: ");

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    int.TryParse(Console.ReadLine()!, out array[i]);
    if (array[i] > 0)
        sum++;
}

Console.Write($"Количество положительных чисел {sum}: ");

