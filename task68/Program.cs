int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

int b;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out b);

Console.Write($"Функция Аккермана = {Ack(a, b)} ");

int Ack(int _a, int _b)
{
    if (_a == 0)
        return _b + 1;
    else if (_b == 0)
        return Ack(_a - 1, 1);
    else return Ack(_a - 1, Ack(_a, _b - 1));
}

