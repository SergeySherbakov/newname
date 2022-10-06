int a;
Console.Write("Введите число a: ");
int.TryParse(Console.ReadLine()!, out a);
int b = 2;
if (a % b == 0)
{
    Console.Write($"Четное");
}
else
{
    Console.Write($"Нечетное");
}