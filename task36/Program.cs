int[] CreateArray(int size, int min = 0, int max = 100)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(min, max);
    return _array;
}

int[] array = CreateArray(10, 0, 100);

void PrintArray(int[] _array)
{
    foreach (var item in _array)
        Console.Write($"{item} ");
}

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
        sum = sum + array[i];
}

PrintArray(array);
Console.WriteLine($"\n Сумма элементов, стоящих на нечётных позициях = {sum}");