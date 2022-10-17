int b1;
Console.Write($"Введите b1: ");
int.TryParse(Console.ReadLine()!, out b1);

int k1;
Console.Write($"Введите k1: ");
int.TryParse(Console.ReadLine()!, out k1);

int b2;
Console.Write($"Введите b2: ");
int.TryParse(Console.ReadLine()!, out b2);

int k2;
Console.Write($"Введите k2: ");
int.TryParse(Console.ReadLine()!, out k2);

double x = (double)(b2 - b1) / (k1 - k2);
double y = (double)k1 * x + b1;

Console.Write($"Точка пересечения:({x}; {y})");