// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные четные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите число: ");
string n = Console.ReadLine()!;

Console.Write($"N = {n} -> ");
Console.WriteLine(NaturalNumbers(n));
string NaturalNumbers(string num)
{
    if (num == "1")
    {
        return num + ".";
    }
    else
    {
        return num + ", " + NaturalNumbers(Convert.ToString(int.Parse(num) - 1));
    }
}
