int rand = new Random().Next(100,1000);
Console.WriteLine(rand);
Console.Write($"Второе число = {rand / 10 - rand / 100 * 10}");
