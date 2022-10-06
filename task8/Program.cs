int N;
Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);
int i = 2;
while (i <= N)
{
    Console.Write($"{i} ");
    i = i + 2;
}