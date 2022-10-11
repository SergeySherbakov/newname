int A = 0;
Console.Write($"Введите число A: ");
int.TryParse(Console.ReadLine()!, out A);
int B = 0;
Console.Write($"Введите число B: ");
int.TryParse(Console.ReadLine()!, out B);
Console.Write($"Число {A} в степени {B} = {Mult(A)}");
int Mult(int _A)
{
    int mult = 1;
    for (int i = 1; i <= B; i++)
        mult *= _A;
    return mult;
}


