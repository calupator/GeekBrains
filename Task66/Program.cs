// =====================================================================================================================
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//(НЕ ИСПОЛЬЗОВАТЬ РЕЗУЛЬТИРУЮЩУЮ ПЕРЕМЕННУЮ)
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int Sum(int x, int y)
{
    if (x == y)
        return x;
    return x + Sum(++x, y);
}

Console.Clear();

Console.Write("Введите начало диапазона M = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конец диапазона N = ");
int n = Convert.ToInt32(Console.ReadLine());

while (m > n)
{
    Console.WriteLine("Значение M не должно превышать значение N!!!");

    Console.Write("Введите начало диапазона M = ");
    m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите конец диапазона N = ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("M = " + m + "; N = " + n + " -> " + Sum(m, n));