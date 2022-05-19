// Найти кубы чисел от 1 до N
Console.Clear();
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Кубы чисел от 1 до n: ");
for (int i = 1; i <= n; i++) Console.Write($"{i * i * i} ");
Console.WriteLine();
