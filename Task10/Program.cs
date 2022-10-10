//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Console.Clear();
//Console.Write("Введите трёхзначное число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//if (99 < n)
//{
    //int m = (n - (n % 10) - (n / 100) * 100) / 10;
    //Console.WriteLine("Второе число - " + m);
//}

//--------------
//Второе решение
Console.Clear();
Console.Write("Введите трёхзначное число: ");
string str = Console.ReadLine();
Console.WriteLine("Второе число - {1}", str, str[1]);