// 42 task

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string result = string.Empty;
// while (n > 0)
// {
//     int x = n % 2;
//     result = Convert.ToString(x) + result;
//     n = n / 2;
// }
// Console.WriteLine(result);


// string f(int n)
// {
//     if (n == 0 || n == 1)
//         return $"{n}";
//     return f(n / 2) + $"{n % 2}";
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));

// 44 task
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a0 = 0, a1 = 1;
for (int i = 0; i < n; i++)
{
    Console.Write($"{a0} ");
    int x = a0 + a1;
    a0 = a1;
    a1 = x;
}
