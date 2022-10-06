int a;
Console.Write("Введите число a: ");
int.TryParse(Console.ReadLine()!, out a);
int b;
Console.Write("Введите число b: ");
int.TryParse(Console.ReadLine()!, out b);
if (a>b)
{
    Console.Write($"Большее число = {a}, меньшее число = {b}");
}
else
{
    Console.Write($"Большее число = {b}, меньшее число = {a}");
}





