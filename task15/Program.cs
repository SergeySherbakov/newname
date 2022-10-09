int a = 0;
Console.Write($"Введите число от 1 до 7: ");
int.TryParse(Console.ReadLine()!, out a);
if (a >= 1 && a < 6)
    Console.Write($"Число является рабочим днем");
else if (a > 5 && a < 8)
    Console.Write($"Число является выходным днем");
else
    Console.Write($"Неверно введено число");