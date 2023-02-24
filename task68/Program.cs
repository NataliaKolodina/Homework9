// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите M число: ");
int num1 = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите N число: ");
int num2 = int.Parse(Console.ReadLine()!)!;

Console.Write($"M = {num1}; N = {num2} -> A({num1}, {num2}) = ");
Console.Write(AckermannFunction(num1, num2));

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m != 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0)
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return AckermannFunction(m, n);
}
