double[] array = new double[new Random().Next(6, 10)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = (double)new Random().Next(0, 10 * 10) / 10;
    Console.Write($"{array[i]} ");
}

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (min > array[i])
        min = array[i];
    if (max < array[i])
        max = array[i];
}

Console.Write($"\nmin = {min} max = {max}  Разница между максимальным и минимальным  {max - min}");
