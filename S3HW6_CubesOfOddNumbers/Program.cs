// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine() ?? "0");
if (a % 2 == 0) Console.WriteLine($"Куб числа {a} равен {a * a * a}!");
else Console.WriteLine($"Число {a} не заканчивается на четную цифру!");