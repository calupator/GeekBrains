// =====================================================================================================================
//Задача 61: Вывести первые N строк
//треугольника Паскаля. Сделать вывод в виде
//равнобедренного треугольника

void TriangelPascal(int n)
{
    int i = 0, c = 0;
    for (i = 0; i < n; i++)
    {
        for (c = 0; c <= (n - i); c++) // кол-во отступов слева в консоле
            Console.Write(" ");

        for (c = 0; c <= i; c++)
        {
            Console.Write(" "); // отступ между элементами
            Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c))); // вычисление элементов
        }
        Console.WriteLine();
        Console.WriteLine(); // отступ между строками
    }
}

int Factorial(int n)
{
    if (n == 0)
        return 1;
    return (n * Factorial(n - 1));
}

Console.Clear();

Console.Write("Введите количество отображаемых строк треугольника Паскаля: ");
int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Факториал числа {0}! = {1}", n, Factorial(n));
TriangelPascal(n);
