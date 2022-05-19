// Возведите число А в натуральную степень B используя цикл
Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine() ?? "0");
int result = a;
if (b <= 0) Console.WriteLine($"Введенное число b не является натуральным!");
else
{
    for (int i = 2; i <= b; i++) result = result * a;
    Console.WriteLine($"Число {a} в степени {b} = {result}");
}