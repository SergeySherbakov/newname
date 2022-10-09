int a = 0;
Console.Write($"Введите пятизначное число: ");
int.TryParse(Console.ReadLine()!, out a);
if(a / 10000 == a % 10 && a / 1000 % 10 == a / 10 % 10)
   Console.Write($"Число является палиндромом");
else
   Console.Write($"Число не является палиндромом");