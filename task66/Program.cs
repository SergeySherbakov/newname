int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

int b;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out b);

Console.Write($"Сумма чисел между {a} и {b} = {SumNumbers(a, b)}");

static int SumNumbers(int _start, int _end)
{
    if (_start == _end)
        return _start;
    return _end + SumNumbers(_start, _end - 1);
}
