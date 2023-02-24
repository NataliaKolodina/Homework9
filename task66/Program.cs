// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите начальное число: ");
int first = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите конечное число: ");
int last = int.Parse(Console.ReadLine()!)!;

Console.Write($"M = {first}; N = {last} -> ");
Console.Write(SumElements(first, last));

int SumElements(int start, int end)
{
    if (end == start)
    {
        return start;
    }
    else
    {
        return end + SumElements(start, end - 1);
    }
}
