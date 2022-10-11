int[] array;
array = CreateArray();
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
int[] CreateArray()
{
    int[] _array = new int[8];
    for (int i = 0; i < 8; i++)
        _array[i] = new Random().Next(100);
    return _array;
}

