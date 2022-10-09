int a;
int.TryParse(Console.ReadLine()!, out a);
int temp = a;
int k = 0;
while(temp > 0)
{
    temp /= 10;
    k++;
}
if(k > 2)
   Console.Write($"{(a / (int)Math. Pow(10, k-3)) % 10}");
else
   Console.Write($"Третьей цифры нет");