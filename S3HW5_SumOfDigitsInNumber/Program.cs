// Подсчитать сумму цифр в числе
Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int count = 0;
if (a == 0) Console.WriteLine("Сумма цифр равна 1!");
else
{
    while (a > 0 || a < 0) 
    {
        a = a / 10;
        count = count + 1;
    }
    Console.WriteLine($"Сумма цифр равна {count}!");
}
