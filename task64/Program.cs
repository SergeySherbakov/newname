int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

PrintNumbers(a, 1);

void PrintNumbers(int _start, int _end)
{
    if (_start >= _end)
    {
        Console.Write($"{_start} ");
        PrintNumbers(_start - 1, _end);
    }
}
