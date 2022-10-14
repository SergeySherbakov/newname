int[] CreateArray(int size, int min = 100, int max = 1000)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(min, max);
    return _array;
}

int[] array = CreateArray(15, 100, 1000);

void PrintArray(int[] _array)
{
    foreach (var item in _array)
        Console.Write($"{item} ");
}


int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        sum = sum + 1;
}

PrintArray(array);
Console.WriteLine($"\n Сумма четных чисел = {sum}");