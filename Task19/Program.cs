Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// if (n < 0)
//     n *= -1;
while (n < 10000 || n > 99999)
{
    Console.Write("Число не пятизначное!\nВведите пятизначное число: ");
    n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
//int n1 = n / 10000;
//int n2 = (n / 1000) % 10;
//int n4 = (n % 100) / 10;
//int n5 = n % 10;
//if (n1 == n5 && n2 == n4)
//    Console.WriteLine("Да");
//else
//    Console.WriteLine("Нет");

int res = 0;
int tmp = n;
while (tmp > 0)
{
    res = res * 10 + tmp % 10;
    tmp /= 10;
}
if (n == res)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");
