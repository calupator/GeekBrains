// =====================================================================================================================
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.Write("Введите число: ");
Int64 a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени: ");
Int64 b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Int64 result = a;
for (int i = 1; i < b; i++)
{
    result *= a;
}
Console.WriteLine("a^b = " + result);
