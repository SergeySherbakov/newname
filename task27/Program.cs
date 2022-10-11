int rand = new Random().Next();
Console.WriteLine(rand);
int sum = 0;
while (rand > 0)
{
    sum = sum + rand % 10;
    rand = rand / 10;
}
Console.Write($"Сумма цифр = {sum}: ");