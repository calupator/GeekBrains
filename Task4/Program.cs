//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22
//Console.WriteLine("Введите три числа...");
//int[] a = new int[3] { 2, 3, 7 };
int[] a = new int[3] { 44, 5, 78 };
//int[] a = new int[3] {22, 3, 9};
int min = 0, max = 0;
//for(int i = 0; i < a.Length; i++)
//{
//    a[i] = Convert.ToInt32(Console.ReadLine());
//}
min = a[0];
for(int i = 0; i < a.Length; i++)
{
    if(a[i] > max)
        max = a[i];
}
Console.WriteLine("max = " + max);
