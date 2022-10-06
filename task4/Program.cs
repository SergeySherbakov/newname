int a;
Console.Write("Введите число a: ");
int.TryParse(Console.ReadLine()!, out a);
int b;
Console.Write("Введите число b: ");
int.TryParse(Console.ReadLine()!, out b);
int c;
Console.Write("Введите число c: ");
int.TryParse(Console.ReadLine()!, out c);
int max = 0;
if (a > b && a > c)
    max = a;
else if (b > c && b > a)
    max = b;
else if (c > a && c > b)
    max = c;
Console.Write($"Большее число = {max}");
