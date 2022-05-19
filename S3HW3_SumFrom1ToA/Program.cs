// Найти сумму чисел от 1 до А
Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
for (int i = 1; i <= a; i++) sum = sum + i;
Console.WriteLine($"Сумма чисел от 1 до {a}: {sum}");
